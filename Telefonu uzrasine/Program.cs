

namespace Telefonu_uzrasine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            string dbAdress = "Data Source=HP-2\\SQLEXPRESS;Initial Catalog=UzrasuKnyga;Integrated Security=True;MultipleActiveResultSets=true; TrustServerCertificate=true; Connect Timeout=1";

            SqlAction sqlAction = new SqlAction(dbAdress);
            if (sqlAction.checkConnection())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Main(sqlAction));
            }
            else
            {
                MessageBox.Show("Negalimas sujungimas", "Pranesimas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}