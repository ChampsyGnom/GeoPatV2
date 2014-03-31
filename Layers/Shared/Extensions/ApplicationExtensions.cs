﻿using System;
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
    }
}