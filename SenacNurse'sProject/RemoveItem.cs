using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SenacNurse_sProject
{
    public partial class RemoveItem: Form
    {
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(IDTextBox.Text);
            var quantity = Convert.ToInt32(QuantityTextBox.Text);
            string connectionString = "Data Source=meuBancoDeDados.sqlite;Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string RemoveCountQuery = "UPDATE Itens SET Quantity = Quantity - @Quantity WHERE ID = @ID";
                using(SQLiteCommand command = new SQLiteCommand(RemoveCountQuery, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Quantidade usada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum item encontrado com o ID fornecido");
                    }
                }
            }

        }
    }
}
