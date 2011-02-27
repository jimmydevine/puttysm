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
using System;

namespace uk.org.riseley.puttySessionManager.model.exception 
{
    public class RemoteSessionImportException : SessionImportException
    {
        public RemoteSessionImportException(string message)
            : base(message)
        {
        }

        public RemoteSessionImportException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public RemoteSessionImportException(string message, 
                                            Exception innerException,
                                            bool proxyAuthRequested,
                                            string proxyRealm)
            : base(message, innerException)
        {
            this.proxyAuthRequested = proxyAuthRequested;
            this.proxyRealm = proxyRealm;
        }

        private bool proxyAuthRequested = false;
        public bool ProxyAuthRequested 
        {
            get { return proxyAuthRequested; }
        }

        private string proxyRealm;
        public string ProxyRealm
        {
            get { return proxyRealm; }
        }
    }
}
