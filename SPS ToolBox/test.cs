﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SPS_ToolBox
{
    class test
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        void SwitchDatabase(string mainWindowTitle)
        {
            try
            {
                bool launched = false;

                Process[] processList = Process.GetProcesses();

                foreach (Process theProcess in processList)
                {
                    ShowWindow(theProcess.MainWindowHandle, 2);
                }

                foreach (Process theProcess in processList)
                {
                    if (theProcess.MainWindowTitle.ToUpper().Contains(mainWindowTitle.ToUpper()))
                    {
                        ShowWindow(theProcess.MainWindowHandle, 9);
                        launched = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //ThrowStandardException(ex);
            }
        }
    }
}
