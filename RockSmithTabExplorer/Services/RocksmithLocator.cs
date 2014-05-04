using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.IO;

namespace RockSmithTabExplorer
{
    public static class RocksmithLocator
	{
        public static string SteamFolder()
        {
            RegistryKey steamKey = Registry.LocalMachine.OpenSubKey("Software\\Valve\\Steam") ?? Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Valve\\Steam");
            return steamKey.GetValue("InstallPath").ToString();
        }

        public static List<string> LibraryFolders()
        {
        	List<string> folders = new List<string>();

            string steamFolder = SteamFolder();
            folders.Add(steamFolder);

            string configFile = steamFolder + "\\config\\config.vdf";

            Regex regex = new Regex("BaseInstallFolder[^\"]*\"\\s*\"([^\"]*)\"");
            using (StreamReader reader = new StreamReader(configFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Match match = regex.Match(line);
                    if (match.Success)
                    {
                        folders.Add(Regex.Unescape(match.Groups[1].Value));
                    }
                }
            }

            return folders;
        }

        public static string Rocksmith2014FolderFromUbisoftKey()
        {
            RegistryKey ubiKey = Registry.LocalMachine.OpenSubKey(@"Software\Ubisoft\Rocksmith2014") ?? Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Ubisoft\Rocksmith2014");
            return ubiKey.GetValue("installdir").ToString();
        }

        public static string Rocksmith2014Folder()
        {
            var appFolders = LibraryFolders().Select(x => x + "\\SteamApps\\common");
            foreach (var folder in appFolders)
            {
                try
                {
                    var matches = Directory.GetDirectories(folder, "Rocksmith2014");
                    if (matches.Length >= 1)
                    {
                        return matches[0];
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    //continue;
                }

            }

            // Couldn't find folder, attempt another method
            return Rocksmith2014FolderFromUbisoftKey();
        }
    }
}
