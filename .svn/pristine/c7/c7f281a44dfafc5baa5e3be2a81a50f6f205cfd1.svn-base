using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SleeveSewing
{
    public static class CommonDirectory
    {
        static private readonly string _dataDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

        static private string _companyName = "WLGore";

        /// <summary>
        /// Gets the path of the application's executable directory.
        /// </summary>
        static public string ApplicationExecutionDirectory
        {
            get
            {
                string s = System.Reflection.Assembly.GetExecutingAssembly().Location;
                s = s.Substring(0, s.LastIndexOf("\\"));
                return s;
            }
        }

        /// <summary>
        /// Gets the path of the application's data directory.
        /// </summary>
        static public string ApplicationDataDirectory
        {
            get
            {
                string appDir = ApplicationExecutionDirectory;
                if (appDir.Contains("\\bin"))
                {
                    appDir = appDir.Substring(0, appDir.LastIndexOf("\\bin"));
                }
                appDir = appDir.Substring(appDir.LastIndexOf("\\") + 1);
                string s = Path.Combine(_dataDirectory, _companyName, appDir);
                return s;
            }
        }

        /// <summary>
        /// Gets the path of the application's setup data directory.
        /// </summary>
        static public string SetupDataDirectory
        {
            get
            {
                return Path.Combine(ApplicationDataDirectory, "Setup");
            }
        }

        /// <summary>
        /// Gets the path of the application's recipe data directory.
        /// </summary>
        static public string RecipeDataDirectory
        {
            get
            {
                return Path.Combine(ApplicationDataDirectory, "Recipe");
            }
        }

       

        /// <summary>
        /// Gets the path of the application's log data directory.
        /// </summary>
        static public string LogDataDirectory
        {
            get
            {
                return Path.Combine(ApplicationDataDirectory, "Log");
            }
        }

        /// <summary>
        /// Gets the path of the application's process data directory.
        /// </summary>
        static public string ProcessDataDirectory
        {
            get
            {
                return Path.Combine(ApplicationDataDirectory, "Process");
            }
        }

    }
}
