using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Threading;

using Gore.Generic;
using System.Reflection;

namespace SleeveSewing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        public static string SOFTWARE_TITLE = (Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyTitleAttribute)) as AssemblyTitleAttribute).Title;
        public static string SOFTWARE_MD = (Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyConfigurationAttribute)) as AssemblyConfigurationAttribute).Configuration;
        public static string SOFTWARE_VERSION = $"{System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileMajorPart.ToString()}.{System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileMinorPart.ToString()}";
        public static string MACHINE_NAME = Environment.MachineName;

        override public Window ConstructMainWindow()
        {
            MainWindow MainWindow = new MainWindow(this);
            return MainWindow;
        }

        override public void DefineCustomApp(out string AppGuid, out string AppName)
        {
            AppGuid = "9a3ca1db-36ad-48ec-8051-a1d2283abc32";
            AppName = $"{SOFTWARE_TITLE}\n{SOFTWARE_VERSION}";
        }
    }
}
