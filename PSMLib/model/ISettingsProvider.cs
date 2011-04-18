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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
namespace uk.org.riseley.puttySessionManager.model
{
    public interface ISettingsProvider : INotifyPropertyChanged
    {
        string PuttyLocation
        {
            get;
            set;
        }

        bool HotkeyNewEnabled
        {
            get;
            set;
        }
        
        bool HotkeyFavouriteEnabled {
            get;
            set;
        }
        
        string FavouriteSession1 {
            get;
            set;
        }
        
        string FavouriteSession2 {
            get;
            set;
        }
        
        string FavouriteSession3 {
            get;
            set;
        }
        
        string FavouriteSession4 {
            get;
            set;
        }
        
        string FavouriteSession5 {
            get;
            set;
        }
        
        bool HotkeyMinimizeEnabled {
            get;
            set;
        }
        
        string UpdateUrl {
            get;
            set;
        }
        
        int ProxyMode {
            get;
            set;
        }
        
        string ProxyServer {
            get;
            set;
        }
        
        string ProxyPort {
            get;
            set;
        }
        
        string DefaultUpdateUrl {
            get;
            set;
        }
        
        int SortOrder {
            get;
            set;
        }
        
        bool UpgradeRequired {
            get;
            set;
        }
        
        string FavouriteSession6 {
            get;
            set;
        }
        
        string FavouriteSession7 {
            get;
            set;
        }
        
        string FavouriteSession8 {
            get;
            set;
        }
        
        string FavouriteSession9 {
            get;
            set;
        }
        
        string FavouriteSession10 {
            get;
            set;
        }
        
        bool Hotkey1Enabled {
            get;
            set;
        }
        
        bool Hotkey2Enabled {
            get;
            set;
        }
        
        bool Hotkey3Enabled {
            get;
            set;
        }
        
        bool Hotkey4Enabled {
            get;
            set;
        }
        
        bool Hotkey5Enabled {
            get;
            set;
        }
        
        bool Hotkey6Enabled {
            get;
            set;
        }
        
        bool Hotkey7Enabled {
            get;
            set;
        }
        
        bool Hotkey8Enabled {
            get;
            set;
        }
        
        bool Hotkey9Enabled {
            get;
            set;
        }
        
        bool Hotkey10Enabled {
            get;
            set;
        }
        
        char HotkeyNewSession {
            get;
            set;
        }
        
        char HotkeyMinimize {
            get;
            set;
        }
        
        char HotkeySession1 {
            get;
            set;
        }
        
        char HotkeySession2 {
            get;
            set;
        }
        
        char HotkeySession3 {
            get;
            set;
        }
        
        char HotkeySession4 {
            get;
            set;
        }
        
        char HotkeySession5 {
            get;
            set;
        }
        
        char HotkeySession6 {
            get;
            set;
        }
        
        char HotkeySession7 {
            get;
            set;
        }
        
        char HotkeySession8 {
            get;
            set;
        }
        
        char HotkeySession9 {
            get;
            set;
        }
        
        char HotkeySession10 {
            get;
            set;
        }
        
        string PageantLocation {
            get;
            set;
        }
        
        StringCollection PageantKeyList {
            get;
            set;
        }
        
        bool LaunchPageantOnStart {
            get;
            set;
        }
        
        bool MinimizeOnUse {
            get;
            set;
        }
        
        string FileZillaLocation {
            get;
            set;
        }
        
        bool FileZillaEnabled {
            get;
            set;
        }
        
        bool FileZillaAttemptKeyAuth {
            get;
            set;
        }

        int FileZillaProtocol {
            get;
            set;
        }
        
        bool WinSCPEnabled {
            get;
            set;
        }
        
        string WinSCPLocation {
            get;
            set;
        }
        
        int WinSCPProtocol {
            get;
            set;
        }
        
        int WinSCPPrefProtocol {
            get;
            set;
        }
        
        int WinSCPVersion {
            get;
            set;
        }
        
        string WinSCPIniLocation {
            get;
            set;
        }
        
        bool WinSCPIniEnabled {
            get;
            set;
        }
                
        bool ShowInTaskbar {
            get;
            set;
        }

        int HotkeyModifier {
            get;
            set;
        }                       
        
        string SessionSyncUrlLocation {
            get;
            set;
        }
        
        string SessionSyncFileLocation {
            get;
            set;
        }
        
        int FileZillaVersion {
            get;
            set;
        }

        NetworkCredential ProxyCredential
        {
            get;
            set;
        }
    }
}