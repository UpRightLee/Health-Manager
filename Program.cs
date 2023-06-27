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
            bool bnew;

            Mutex mutex = new Mutex(true, "Health_Note", out bnew);

            try
            {
                if (bnew)
                {
                    dataBaseManager.CreateDB();
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainForm());

                    mutex.ReleaseMutex();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MAIN");
            }
            finally
            {
                mutex.Close();
            }          
        }
    }
}