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
            DataLoad();
        }
        private void DataLoad()
        //abrindo conexão com o banco de dados
        {
            string connectionString = "Data Source=meuBancoDeDados.sqlite;Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //Seleciona a tabela a ser mostrada, chama a Classe SQLiteDataAdapter passando como parametro a sintaxe SQL query e a conexão
            {
                connection.Open();
                string Query = "SELECT * FROM Itens";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, connection);
                //Criando uma classe DataTable que é uma classe que recebe os dados de tabelas
                DataTable dataTable = new DataTable();
                //está chamando a função do SQLiteDataAdapter Fill com parametro o objeto dataTable que preenche a tabela com os dados da dataTable
                adapter.Fill(dataTable);
                dataGridViewAddDelete.DataSource = dataTable;
                dataGridViewAddDelete.DataSource = dataTable;
            }
        }
        //criando o evento do botão adicionar
        private void button1_Click(object sender, EventArgs e)
        //fazendo as variaveis que vão receber os valores do input
        {
            string name = TextBoxAddName.Text;
            var quantity = Convert.ToInt32(textBoxAddQuantity.Text);
            //abrindo a conexão com o banco de dados, poderia utilizar uma interface para reutilizar o codigo e só sobescrever "override"
            string connectionString = "Data Source=meuBancoDeDados.sqlite;version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //passando os parametros para inserir no banco de dados na tabela itens, passando os valores das variaveis declaradas.
                {
                    string InsertQuery = $"INSERT INTO Itens (Name, Quantity) VALUES ('{name}', '{quantity}')";
                    using (SQLiteCommand command = new SQLiteCommand(InsertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        DataLoad();
                    }
                }
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada nao é um dígito nem a tecla de controle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere não permitido seja processado
            }
        }
        private void DeleteBottom_Click(object sender, EventArgs e)
        {
            string name = DeleteNameLabel.Text;
            var ID = Convert.ToInt32(DeleteLabelID.Text);
            //abrindo a conexão com o banco de dados, poderia utilizar uma interface para reutilizar o codigo e só sobescrever "override"
            string connectionString = "Data Source=meuBancoDeDados.sqlite;version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = $"DELETE FROM Itens WHERE ID = @id AND Name = @name";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@name", name);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 0) 
                    {
                        MessageBox.Show("Item excluido com sucesso");
                        DataLoad();
                    }
                    else
                    {
                        MessageBox.Show("Não deu certo excluir");
                    }
                    
                }
            }
        }
    }
}