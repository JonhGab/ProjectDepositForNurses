using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SenacNurse_sProject
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            string connectionString = "Data Source=meuBancoDeDados.sqlite;Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = " CREATE TABLE IF NOT EXISTS Itens (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Quantity INTEGER)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

               
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());


        }
    }
}
