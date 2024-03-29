﻿using System;
using System.Windows.Forms;

namespace Lab2.Interfaces.WinForm {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ComponentSelectionForm());
        }
    }
}
