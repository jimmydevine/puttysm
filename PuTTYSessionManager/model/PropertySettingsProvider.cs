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
namespace uk.org.riseley.puttySessionManager.model
{
    public class PropertySettingsProvider : ISettingsProvider
    {

        public string PuttyLocation
        {
            get
            {
                return Properties.Settings.Default.PuttyLocation;
            }
            set
            {
                Properties.Settings.Default.PuttyLocation = value;
            }
        }

        public bool HotkeyNewEnabled
        {
            get
            {
                return Properties.Settings.Default.HotkeyNewEnabled;
            }
            set
            {
                Properties.Settings.Default.HotkeyNewEnabled = value;
            }
        }

        public bool HotkeyFavouriteEnabled
        {
            get
            {
                return Properties.Settings.Default.HotkeyFavouriteEnabled;
            }
            set
            {
                Properties.Settings.Default.HotkeyFavouriteEnabled = value;
            }
        }

        public string FavouriteSession1
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession1;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession1 = value;
            }
        }

        public string FavouriteSession2
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession2;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession2 = value;
            }
        }

        public string FavouriteSession3
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession3;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession3 = value;
            }
        }

        public string FavouriteSession4
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession4;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession4 = value;
            }
        }

        public string FavouriteSession5
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession5;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession5 = value;
            }
        }

        public bool HotkeyMinimizeEnabled
        {
            get
            {
                return Properties.Settings.Default.HotkeyMinimizeEnabled;
            }
            set
            {
                Properties.Settings.Default.HotkeyMinimizeEnabled = value;
            }
        }

        public string UpdateUrl
        {
            get
            {
                return Properties.Settings.Default.UpdateUrl;
            }
            set
            {
                Properties.Settings.Default.UpdateUrl = value;
            }
        }

        public int ProxyMode
        {
            get
            {
                return Properties.Settings.Default.ProxyMode;
            }
            set
            {
                Properties.Settings.Default.ProxyMode = value;
            }
        }

        public string ProxyServer
        {
            get
            {
                return Properties.Settings.Default.ProxyServer;
            }
            set
            {
                Properties.Settings.Default.ProxyServer = value;
            }
        }

        public string ProxyPort
        {
            get
            {
                return Properties.Settings.Default.ProxyPort;
            }
            set
            {
                Properties.Settings.Default.ProxyPort = value;
            }
        }

        public string DefaultUpdateUrl
        {
            get
            {
                return Properties.Settings.Default.DefaultUpdateUrl;
            }
            set
            {
                Properties.Settings.Default.DefaultUpdateUrl = value;
            }
        }

        public int SortOrder
        {
            get
            {
                return Properties.Settings.Default.SortOrder;
            }
            set
            {
                Properties.Settings.Default.SortOrder = value;
            }
        }

        public bool UpgradeRequired
        {
            get
            {
                return Properties.Settings.Default.UpgradeRequired;
            }
            set
            {
                Properties.Settings.Default.UpgradeRequired = value;
            }
        }

        public string FavouriteSession6
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession6;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession6 = value;

            }
        }

        public string FavouriteSession7
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession7;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession7 = value;
            }
        }

        public string FavouriteSession8
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession8;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession8 = value;
            }
        }

        public string FavouriteSession9
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession9;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession9 = value;
            }
        }

        public string FavouriteSession10
        {
            get
            {
                return Properties.Settings.Default.FavouriteSession10;
            }
            set
            {
                Properties.Settings.Default.FavouriteSession10 = value;
            }
        }

        public bool Hotkey1Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey1Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey1Enabled = value;
            }
        }

        public bool Hotkey2Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey2Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey2Enabled = value;
            }
        }

        public bool Hotkey3Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey3Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey3Enabled = value;
            }
        }

        public bool Hotkey4Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey4Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey4Enabled = value;

            }
        }

        public bool Hotkey5Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey5Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey5Enabled = value;
            }
        }

        public bool Hotkey6Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey6Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey6Enabled = value;
            }
        }

        public bool Hotkey7Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey7Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey7Enabled = value;
            }
        }

        public bool Hotkey8Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey8Enabled;
            }
            set
            {
                 Properties.Settings.Default.Hotkey8Enabled = value;
            }
        }

        public bool Hotkey9Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey9Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey9Enabled = value;
            }
        }

        public bool Hotkey10Enabled
        {
            get
            {
                return Properties.Settings.Default.Hotkey10Enabled;
            }
            set
            {
                Properties.Settings.Default.Hotkey10Enabled = value;
            }
        }

        public char HotkeyNewSession
        {
            get
            {
                return Properties.Settings.Default.HotkeyNewSession;
            }
            set
            {
                Properties.Settings.Default.HotkeyNewSession = value;
            }
        }

        public char HotkeyMinimize
        {
            get
            {
                return Properties.Settings.Default.HotkeyMinimize;
            }
            set
            {
                Properties.Settings.Default.HotkeyMinimize = value;
            }
        }

        public char HotkeySession1
        {
            get
            {
                return Properties.Settings.Default.HotkeySession1;
            }
            set
            {
                Properties.Settings.Default.HotkeySession1 = value;
            }
        }

        public char HotkeySession2
        {
            get
            {
                return Properties.Settings.Default.HotkeySession2;
            }
            set
            {
                Properties.Settings.Default.HotkeySession2 = value;
            }
        }

        public char HotkeySession3
        {
            get
            {
                return Properties.Settings.Default.HotkeySession3;
            }
            set
            {
                Properties.Settings.Default.HotkeySession3 = value;
            }
        }

        public char HotkeySession4
        {
            get
            {
                return Properties.Settings.Default.HotkeySession4;
            }
            set
            {
                Properties.Settings.Default.HotkeySession4 = value;
            }
        }

        public char HotkeySession5
        {
            get
            {
                return Properties.Settings.Default.HotkeySession5;
            }
            set
            {
                Properties.Settings.Default.HotkeySession5 = value;
            }
        }

        public char HotkeySession6
        {
            get
            {
                return Properties.Settings.Default.HotkeySession6;
            }
            set
            {
                Properties.Settings.Default.HotkeySession6 = value;
            }
        }

        public char HotkeySession7
        {
            get
            {
                return Properties.Settings.Default.HotkeySession7;
            }
            set
            {
                Properties.Settings.Default.HotkeySession7 = value;
            }
        }

        public char HotkeySession8
        {
            get
            {
                return Properties.Settings.Default.HotkeySession8;

            }
            set
            {
                Properties.Settings.Default.HotkeySession8 = value;
            }
        }

        public char HotkeySession9
        {
            get
            {
                return Properties.Settings.Default.HotkeySession9;
            }
            set
            {
                Properties.Settings.Default.HotkeySession9 = value;
            }
        }

        public char HotkeySession10
        {
            get
            {
                return Properties.Settings.Default.HotkeySession10;
            }
            set
            {
                Properties.Settings.Default.HotkeySession10 = value;
            }
        }

        public string PageantLocation
        {
            get
            {
                return Properties.Settings.Default.PageantLocation;
            }
            set
            {
                Properties.Settings.Default.PageantLocation = value;
            }
        }

        public System.Collections.Specialized.StringCollection PageantKeyList
        {
            get
            {
                return Properties.Settings.Default.PageantKeyList;
            }
            set
            {
                Properties.Settings.Default.PageantKeyList = value;
            }
        }

        public bool LaunchPageantOnStart
        {
            get
            {
                return Properties.Settings.Default.LaunchPageantOnStart;
            }
            set
            {
                Properties.Settings.Default.LaunchPageantOnStart = value;
            }
        }

        public bool MinimizeOnUse
        {
            get
            {
                return Properties.Settings.Default.MinimizeOnUse;
            }
            set
            {
                Properties.Settings.Default.MinimizeOnUse = value;
            }
        }

        public string FileZillaLocation
        {
            get
            {
                return Properties.Settings.Default.FileZillaLocation;
            }
            set
            {
                Properties.Settings.Default.FileZillaLocation = value;
            }
        }

        public bool FileZillaEnabled
        {
            get
            {
                return Properties.Settings.Default.FileZillaEnabled;
            }
            set
            {
                Properties.Settings.Default.FileZillaEnabled = value;
            }
        }

        public bool FileZillaAttemptKeyAuth
        {
            get
            {
                return Properties.Settings.Default.FileZillaAttemptKeyAuth;
            }
            set
            {
                Properties.Settings.Default.FileZillaAttemptKeyAuth = value;
            }
        }

        public int FileZillaProtocol
        {
            get
            {
                return Properties.Settings.Default.FileZillaProtocol;
            }
            set
            {
                Properties.Settings.Default.FileZillaProtocol = value;
            }
        }

        public bool WinSCPEnabled
        {
            get
            {
                return Properties.Settings.Default.WinSCPEnabled;
            }
            set
            {
                Properties.Settings.Default.WinSCPEnabled = value;
            }
        }

        public string WinSCPLocation
        {
            get
            {
                return Properties.Settings.Default.WinSCPLocation;
            }
            set
            {
                Properties.Settings.Default.WinSCPLocation = value;
            }
        }

        public int WinSCPProtocol
        {
            get
            {
                return Properties.Settings.Default.WinSCPProtocol;
            }
            set
            {
                Properties.Settings.Default.WinSCPProtocol = value;
            }
        }

        public int WinSCPPrefProtocol
        {
            get
            {
                return Properties.Settings.Default.WinSCPPrefProtocol;
            }
            set
            {
                 Properties.Settings.Default.WinSCPPrefProtocol = value;
            }
        }

        public int WinSCPVersion
        {
            get
            {
                return Properties.Settings.Default.WinSCPVersion;
            }
            set
            {
                 Properties.Settings.Default.WinSCPVersion = value;
            }
        }

        public string WinSCPIniLocation
        {
            get
            {
                return Properties.Settings.Default.WinSCPIniLocation;
            }
            set
            {
                Properties.Settings.Default.WinSCPIniLocation = value;
            }
        }

        public bool WinSCPIniEnabled
        {
            get
            {
                return Properties.Settings.Default.WinSCPIniEnabled;
            }
            set
            {
                Properties.Settings.Default.WinSCPIniEnabled = value;
            }
        }

        public bool ShowInTaskbar
        {
            get
            {
                return Properties.Settings.Default.ShowInTaskbar;
            }
            set
            {
                Properties.Settings.Default.ShowInTaskbar = value;
            }
        }

        public int HotkeyModifier
        {
            get
            {
                return Properties.Settings.Default.HotkeyModifier;
            }
            set
            {
                Properties.Settings.Default.HotkeyModifier = value;
            }
        }

        public string SessionSyncUrlLocation
        {
            get
            {
                return Properties.Settings.Default.SessionSyncUrlLocation;
            }
            set
            {
                Properties.Settings.Default.SessionSyncUrlLocation = value;
            }
        }

        public string SessionSyncFileLocation
        {
            get
            {
                return Properties.Settings.Default.SessionSyncFileLocation;
            }
            set
            {
                Properties.Settings.Default.SessionSyncFileLocation = value;
            }
        }

        public int FileZillaVersion
        {
            get
            {
                return Properties.Settings.Default.FileZillaVersion;
            }
            set
            {
                Properties.Settings.Default.FileZillaVersion = value;
            }
        }
    }
}
