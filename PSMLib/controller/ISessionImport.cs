/* 
 * Copyright (C) 2008 David Riseley 
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
using System.Text;
using uk.org.riseley.puttySessionManager.model;

namespace uk.org.riseley.puttySessionManager.controller
{
    /// <summary>
    /// The contract for a session import provider
    /// </summary>
    interface ISessionImport
    {
        /// <summary>
        /// Return a description of the export file type
        /// </summary>
        /// <returns></returns>
        string getFileTypeDescription();

        /// <summary>
        /// Return the file extension
        /// </summary>
        /// <returns></returns>
        string getFileTypeExtension();

        /// <summary>
        /// Load the session list from the specified Uri
        /// This may throw an exception if there is some issue
        /// with the file I/O
        /// </summary>
        /// <param name="location"></param>
        /// <param name="proxySettings"></param>
        /// <returns></returns>
        List<Session> loadSessions(String location, ProxySettings proxySettings);
    }
}
