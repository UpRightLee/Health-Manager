using System.Drawing.Text;

namespace HealthNote
{
    public static class Program
    {
        private static DataBaseManager dataBaseManager = DataBaseManager.Instance;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            dataBaseManager.CreateDB();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}