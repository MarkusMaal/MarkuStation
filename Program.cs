﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarkuStation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(true);
                Application.Run(new Form1());
            } catch
            {
                return;
            }
        }
    }
}
