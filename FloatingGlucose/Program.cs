﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingGlucose
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormGlucoseSettings());
            //Application.Run(new FormAudioTester());
            //return;
            try
            {
                Application.Run(new FloatingGlucose());
            }
            catch (ObjectDisposedException) {
                // this happens when application.exit() is called when the form has a modal dialog open
                // ignore for now
            }
            
        }
    }
}
