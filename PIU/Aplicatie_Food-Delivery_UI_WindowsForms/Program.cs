using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarieModele;
using NivelStocareDate;
using System.Windows.Forms;
using System.ComponentModel;


namespace Aplicatie_Food_Delivery_UI_WindowsForms
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
           // Application.Run(new Form1());
            Application.Run(new FormMeniu());
        }
    }
}
