﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;
using Sistema.Model;
using Sistema.View.views;
namespace Sistema.View
{
    internal static class Program
    {

      

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
          //  Application.Run(new TesteCheckBox());
        }
    }
}
