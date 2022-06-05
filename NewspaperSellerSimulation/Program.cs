using System;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SimulationSystem system = new SimulationSystem();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
