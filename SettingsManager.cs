using System;
using System.IO;
using System.Windows.Forms;

namespace ReverseRepetitiveClicker
{
    public static class SettingsManager
    {
        private static readonly string iniFilePath = Path.Combine(Application.StartupPath, "settings.ini");

        /// <summary>
        /// Reads a setting from the INI file.
        /// Returns defaultValue if not found.
        /// </summary>
        public static string ReadSetting(string key, string defaultValue = "")
        {
            if (!File.Exists(iniFilePath))
                return defaultValue;

            foreach (var line in File.ReadAllLines(iniFilePath))
            {
                if (line.StartsWith(key + "="))
                    return line.Substring(key.Length + 1);
            }

            return defaultValue;
        }

        /// <summary>
        /// Saves a setting to the INI file.
        /// Updates the value if key already exists.
        /// </summary>
        public static void SaveSetting(string key, string value)
        {
            string[] lines;
            if (File.Exists(iniFilePath))
                lines = File.ReadAllLines(iniFilePath);
            else
                lines = new string[0];

            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(key + "="))
                {
                    lines[i] = key + "=" + value;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                var newLines = new string[lines.Length + 1];
                lines.CopyTo(newLines, 0);
                newLines[lines.Length] = key + "=" + value;
                lines = newLines;
            }

            File.WriteAllLines(iniFilePath, lines);
        }

        /// <summary>
        /// Reads MaxN from INI as integer.
        /// Returns fallback if invalid.
        /// </summary>
        public static int GetMaxN(int fallback = 8)
        {
            string val = ReadSetting("MaxN", fallback.ToString());
            if (int.TryParse(val, out int maxN) && maxN > 0)
                return maxN;
            return fallback;
        }

        /// <summary>
        /// Saves MaxN to INI.
        /// </summary>
        public static void SetMaxN(int maxN)
        {
            SaveSetting("MaxN", maxN.ToString());
        }
    }
}
