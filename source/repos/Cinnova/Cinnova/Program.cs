using System.Windows.Forms;
using Cinnova.Database;
using Cinnova.Forms;
namespace Cinnova
{
    public partial class program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (DatabaseHelper.TestConnection())
                MessageBox.Show("Database Connected Successfully!");
            else
                MessageBox.Show("Database Connection Failed!");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}