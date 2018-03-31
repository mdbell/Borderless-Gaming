using System;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace BorderlessGaming.Logic.System
{
    public class AppEnvironment
    {
        public static string Path = Assembly.GetEntryAssembly().Location;
        public static string LanguagePath = global::System.IO.Path.Combine(DataPath, "Languages");
        public static string ConfigPath = global::System.IO.Path.Combine(DataPath, "config.bin");

        public static string DataPath
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
        }
    }
}