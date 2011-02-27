/* 
 * Copyright (C) 2007 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using FileHelpers;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.exception;

namespace uk.org.riseley.puttySessionManager.controller
{
    public class CsvSessionImportImpl : ISessionImport
    {
        /// <summary>
        /// The file type for this provider
        /// </summary>
        private const string IMPORT_FILE_TYPE = "csv";

        /// <summary>
        /// The file description for this provider
        /// </summary>
        private const string IMPORT_FILE_DESCRIPTION = "CSV File";

        #region SessionExportInterface Members

        /// <summary>
        /// Get a description for the file type
        /// </summary>
        /// <returns></returns>
        public string getFileTypeDescription()
        {
            return IMPORT_FILE_DESCRIPTION;
        }

        /// <summary>
        /// Get the file extension
        /// </summary>
        /// <returns></returns>
        public string getFileTypeExtension()
        {
            return IMPORT_FILE_TYPE;
        }

        /// <summary>
        /// Import the sessions in this providers type
        /// This may throw an exception if there are File I/O issues
        /// </summary>
        /// <param name="location">The location of the csv file</param>
        /// <returns>The list of sessions</returns>
        public List<Session> loadSessions(string location, ProxySettings proxySettings)  
        {
            Uri uri = null;
            try
            {
                uri = new Uri(location);
            }
            catch (Exception e)
            {
                throw new SessionImportException("Unable to parse location: " + e.Message, e);
            }

            FileHelperEngine<CsvRecord> engine = new FileHelperEngine<CsvRecord>();
            List<CsvRecord> csvList = null;
            List<Session> sessionList = null;

            if (uri.Scheme == Uri.UriSchemeFile)
            {
                try
                {
                    csvList = new List<CsvRecord>(engine.ReadFile(uri.LocalPath));
                }
                catch (Exception e)
                {
                    throw new SessionImportException("Unable to parse sessions file." + Environment.NewLine +
                                        "The file may be corrupted or from" + Environment.NewLine +
                                        "a previous version of PuTTY Session Manager.", e);
                }

            }
            else if (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)
            {
                Stream s = null;
                try
                {
                    s = getRemoteCsvFile(uri, proxySettings);
                    if (s != null)
                    {
                        csvList = new List<CsvRecord>(engine.ReadStream(new StreamReader(s)));
                    }
                }
                catch (RemoteSessionImportException rsie)
                {
                    throw rsie;
                }
                catch (Exception e)
                {
                    throw new SessionImportException("Unable to parse sessions file." + Environment.NewLine +
                                        "The file may be corrupted or from" + Environment.NewLine +
                                        "a previous version of PuTTY Session Manager.", e);
                }
                finally
                {
                    if ( s != null )
                        s.Close();
                }
            }
            else
            {
                throw new SessionImportException("Unable to parse location: unsupported protocol");
            }

            if (csvList != null)
            {
                sessionList = csvList.ConvertAll(new Converter<CsvRecord, Session>(CsvToSessionConvertor));
            }

            return sessionList;
        }

        #endregion

        /// <summary>
        /// Convert the csv record to a Session
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        private Session CsvToSessionConvertor(CsvRecord rec)
        {
            Session s = new Session(Session.convertDisplayToSessionKey(rec.SessionName), rec.FolderName, false);
            s.Hostname = rec.Hostname;
            s.Username = rec.Username;
            s.Portnumber = rec.Portnumber;
            s.Protocol = rec.Protocol;
            return s;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private Stream getRemoteCsvFile(Uri sessionsUri, ProxySettings proxySettings)
        {
            WebClient wc = new WebClient();
            Stream stream = null;

            if (proxySettings == null)
            {
                throw new RemoteSessionImportException("Proxy settings must be supplied");
            }

            // Set the proxy options
            SessionController.ProxyMode proxyMode = proxySettings.Mode;
            if (proxyMode == SessionController.ProxyMode.PROXY_IE)
            {
                wc.Proxy = WebRequest.GetSystemWebProxy();
            }
            else if (proxyMode == SessionController.ProxyMode.PROXY_NONE)
            {
                wc.Proxy = null;
            }
            else if (proxyMode == SessionController.ProxyMode.PROXY_USER)
            {
                WebProxy wp = new WebProxy();

                Uri proxyUri;

                try
                {
                    // Create a new Uri object.
                    proxyUri = new Uri("http://" + proxySettings.Host
                                           + ":" + proxySettings.Port);
                    wp.Address = proxyUri;
                    wc.Proxy = wp;
                }
                catch (UriFormatException ufe)
                {
                    throw new RemoteSessionImportException("Check Proxy configuration: " + 
                                                            Environment.NewLine + ufe.Message
                                                            ,ufe);
                }

            }

            // Check if proxy auth is requested
            try
            {                    
                // Make sure that the file hasn't been cached by a proxy
                wc.Headers.Add("Cache-Control: max-age=0");
                wc.Proxy.Credentials = proxySettings.Credential;
                stream = wc.OpenRead(sessionsUri);
            }
            catch (WebException we)
            {

                // Close the stream if it's been opened
                if (stream != null)
                    stream.Close();

                // If the exception was a protocol error 
                // and proxy authentication is required 
                // ask for the credentials
                if (we.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse hwe = (HttpWebResponse)we.Response;
                    if (hwe.StatusCode == HttpStatusCode.ProxyAuthenticationRequired)
                    {
                        String realmHeader = hwe.Headers.Get("Proxy-Authenticate");
                        String realm = "";
                        if (realmHeader != null)
                            realm = realmHeader.Substring(realmHeader.IndexOf("=") + 1);

                        throw new RemoteSessionImportException("Proxy Authenication requested"
                                                               , we
                                                               , true
                                                               , realm);
                    }
                }
                else
                {
                    throw new RemoteSessionImportException("Unable to connect to remote host: " + we.Message, we);                            
                }
            }

            return stream;
        }
    }
}
