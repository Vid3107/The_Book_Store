﻿using Book_Storee;
using Book_Storee.Forms.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Book_Store.Admin;
using The_Book_Store.Auth;
using The_Book_Store.Cashier;
namespace The_Book_Store
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin2());
        }
    }
}
