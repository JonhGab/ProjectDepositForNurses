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
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {   string name = TextBoxAddName.Text;
            var quantity = Convert.ToInt32(textBoxAddQuantity.Text);
            string connectionString = "Data Source=meuBancoDeDados.sqlite;version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                {
                    string InsertQuery = $"INSERT INTO Itens (Name, Quantity) VALUES ('{name}', '{quantity}')";
                    using(SQLiteCommand command = new SQLiteCommand(InsertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}