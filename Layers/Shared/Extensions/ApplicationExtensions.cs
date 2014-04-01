using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace System.Windows
{
    public static  class ApplicationExtensions
    {
        public static String GetStartupPath(this Application app)
        {
            String appStartPath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            return appStartPath;
        }
        public static Window GetActiveWindow(this Application currentApp)
        {
            return Application.Current.Windows.Cast<Window>().SingleOrDefault(x => x.IsActive);
        }
    }
}
