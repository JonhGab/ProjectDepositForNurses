using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacNurse_sProject
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataBaseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataLoad()
        {
            string connectionString = "Data Source=meuBancoDeDados.sqlite;Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string Query = "SELECT * FROM Itens";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataBaseTable.DataSource = dataTable;
            }

        }
    } 
}
