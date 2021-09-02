﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace ScrunchPLUS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread thread = new Thread(() =>
            {
                //Needed for AUTH.GG server authentication
                OnProgramStart.Initialize("ScrunchPLUS", "735249", "WrAdKO4elsFJwhcqWr3PUJRBBC9hS6x7Y1b", "1.0");
            });
            thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}