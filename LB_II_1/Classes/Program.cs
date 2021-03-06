﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_II_1
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
            Classes.ResourcesConfigEditClass.GetProdjectDir();
            Classes.ResourcesConfigEditClass.GetDatabaseDir();
            Application.Run(new StartForm());
        }
    }
}
