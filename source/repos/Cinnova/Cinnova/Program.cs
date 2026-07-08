using Cinnova.Database;
using Cinnova.Forms;
using System;
using System.Windows.Forms;

namespace Cinnova
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (DatabaseHelper.TestConnection())
                MessageBox.Show("Database Connected Successfully!");
            else
                MessageBox.Show("Database Connection Failed!");

            Application.Run(new Cinnova.Forms.FarmerForm());
        }
    }
}