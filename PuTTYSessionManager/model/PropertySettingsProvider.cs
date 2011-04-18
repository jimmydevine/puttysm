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
using System.ComponentModel;
using System.Net;
namespace uk.org.riseley.puttySessionManager.model
{
    public class PropertySettingsProvider : ISettingsProvider
    {

        private static readonly PropertySettingsProvider instance = new PropertySettingsProvider();

        private static NetworkCredential proxyCredential;

        private PropertySettingsProvider() { }

        public static PropertySettingsProvider Instance
        {
            get
            {
                return instance;
            }
        }

        public string PuttyLocation
        {
            get
            {
                return Properties.Settings.Default.PuttyLocation;
            }
            set
            {
                Properties.Settings.Default.PuttyLocation = value;
                OnPropertyChanged("PuttyLocation");
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
                OnPropertyChanged("HotkeyNewEnabled");
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
                OnPropertyChanged("HotkeyFavouriteEnabled");
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
                OnPropertyChanged("FavouriteSession1");
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
                OnPropertyChanged("FavouriteSession2");
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
                OnPropertyChanged("FavouriteSession3");
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
                OnPropertyChanged("FavouriteSession4");
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
                OnPropertyChanged("FavouriteSession5");
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
                OnPropertyChanged("HotkeyMinimizeEnabled");
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
                OnPropertyChanged("UpdateUrl");
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
                OnPropertyChanged("ProxyMode");
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
                OnPropertyChanged("ProxyServer");
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
                OnPropertyChanged("ProxyPort");
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
                OnPropertyChanged("DefaultUpdateUrl");
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
                OnPropertyChanged("SortOrder");
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
                OnPropertyChanged("UpgradeRequired");
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
                OnPropertyChanged("FavouriteSession6");

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
                OnPropertyChanged("FavouriteSession7");
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
                OnPropertyChanged("FavouriteSession8");
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
                OnPropertyChanged("FavouriteSession9");
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
                OnPropertyChanged("FavouriteSession10");
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
                OnPropertyChanged("Hotkey1Enabled");
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
                OnPropertyChanged("Hotkey2Enabled");
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
                OnPropertyChanged("Hotkey3Enabled");
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
                OnPropertyChanged("Hotkey4Enabled");

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
                OnPropertyChanged("Hotkey5Enabled");
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
                OnPropertyChanged("Hotkey6Enabled");
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
                OnPropertyChanged("Hotkey7Enabled");
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
                OnPropertyChanged("Hotkey8Enabled");
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
                OnPropertyChanged("Hotkey9Enabled");
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
                OnPropertyChanged("Hotkey10Enabled");
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
                OnPropertyChanged("HotkeyNewSession");
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
                OnPropertyChanged("HotkeyMinimize");
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
                OnPropertyChanged("HotkeySession1");
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
                OnPropertyChanged("HotkeySession2");
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
                OnPropertyChanged("HotkeySession3");
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
                OnPropertyChanged("HotkeySession4");
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
                OnPropertyChanged("HotkeySession5");
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
                OnPropertyChanged("HotkeySession6");
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
                OnPropertyChanged("HotkeySession7");
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
                OnPropertyChanged("HotkeySession8");
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
                OnPropertyChanged("HotkeySession9");
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
                OnPropertyChanged("HotkeySession10");
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
                OnPropertyChanged("PageantLocation");
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
                OnPropertyChanged("PageantKeyList");
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
                OnPropertyChanged("LaunchPageantOnStart");
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
                OnPropertyChanged("MinimizeOnUse");
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
                OnPropertyChanged("FileZillaLocation");
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
                OnPropertyChanged("FileZillaEnabled");
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
                OnPropertyChanged("FileZillaAttemptKeyAuth");
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
                OnPropertyChanged("FileZillaProtocol");
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
                OnPropertyChanged("WinSCPEnabled");
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
                OnPropertyChanged("WinSCPLocation");
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
                OnPropertyChanged("WinSCPProtocol");
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
                OnPropertyChanged("WinSCPPrefProtocol");
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
                OnPropertyChanged("WinSCPVersion");
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
                OnPropertyChanged("WinSCPIniLocation");
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
                OnPropertyChanged("WinSCPIniEnabled");
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
                OnPropertyChanged("ShowInTaskbar");
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
                OnPropertyChanged("HotkeyModifier");
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
                OnPropertyChanged("SessionSyncUrlLocation");
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
                OnPropertyChanged("SessionSyncFileLocation");
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
                OnPropertyChanged("FileZillaVersion");
            }
        }

        public NetworkCredential ProxyCredential
        {
            get
            {
                return proxyCredential;
            }
            set
            {
                proxyCredential = value;
                OnPropertyChanged("ProxyCredential");
            }
        }



        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
