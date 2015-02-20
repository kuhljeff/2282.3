using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/***********************************
 Reverse Polish Calculator (project 3) - JK
This program takes input from the user
 * in the reverse polish notation
 * and calculates a result.
*************************************/

namespace JeffKuhlmeier_Project3
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
            Application.Run(new Form1());
        }
    }
}
