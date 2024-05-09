using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FeladatI
{
    internal static class Program
    {
        //static bool createdNew;
        static Mutex mutex = new Mutex(true, Application.ProductName, out bool createdNew);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("A program mar fut! Kerem, ellenorizze!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
