/* 
 * Copyright (C) 2011 David Riseley 
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
using uk.org.riseley.puttySessionManager.controller;
using System.Net;

namespace uk.org.riseley.puttySessionManager.model
{
    public class ProxySettings
    {
        private SessionController.ProxyMode mode;
        private string host;
        private int port;
        private NetworkCredential credential;

        public ProxySettings(SessionController.ProxyMode mode
                            , string host
                            , int port
                            )
        {
            this.mode = mode;
            this.host = host;
            this.port = port;
        }


        public ProxySettings(SessionController.ProxyMode mode
                            , string host
                            , int port 
                            , string username
                            , string password) 
            : this(mode,host,port)
        {
            createCredential(username, password);
        }

        public SessionController.ProxyMode Mode
        {
            get { return mode; }
        }

        public string Host
        {
            get { return host; }
        }

        public int Port
        {
            get { return port; }
        }

        public NetworkCredential Credential
        {
            get { return credential; }
            set { credential = value; }
        }

        public void createCredential(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) &&
                !string.IsNullOrEmpty(password))
            {
                credential = new NetworkCredential(username, password);
            }
        }
    }
}
