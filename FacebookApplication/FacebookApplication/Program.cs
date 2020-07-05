using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookApplication
{
     // your grade on diagrams document - 100 well done. please see comments inside the document. 50% of your grade).
     public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}