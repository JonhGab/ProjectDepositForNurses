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
    public partial class RemoveItem : Form
    {
        public RemoveItem()
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
                DataGridViewUse.DataSource = dataTable;
                DataGridViewUse.DataSource = dataTable;
            }
        }
        //verifica se o que o usuario digitar é letra ou numero
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada nao é um dígito nem a tecla de controle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede que o caractere não permitido seja processado
            }
        }
        //criando a ação de clique do botão Usar/Remover item 
        private void button1_Click(object sender, EventArgs e)
        {       //Sintaxe que recebe os valores do input e converte de string para int
            var id = Convert.ToInt32(IDTextBox.Text);
            var quantity = Convert.ToInt32(QuantityTextBox.Text);
            //Sintaxe para abrir a conexão com meu banco de dados
            string connectionString = "Data Source=meuBancoDeDados.sqlite;Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //crindo a variavel com o texto do MySQLite passando a sintaxe SQL para atualizar os dados em determinado parametro
                string RemoveCountQuery = "UPDATE Itens SET Quantity = Quantity - @Quantity WHERE ID = @ID";
                using (SQLiteCommand command = new SQLiteCommand(RemoveCountQuery, connection))
                {      //passando os parametros de onde vai mudar e oque vai mudar, no caso a quantidade vai mudar no ID passado
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ID", id);
                    //sintaxe de execução
                    int rowsAffected = command.ExecuteNonQuery();
                    //comando para verificar se o comando foi executado, caso ocorra erro e caso não ocorra, aparece a mensagem para o usuario
                    if (rowsAffected > 0)
                    {   //chamando a função dataLoad para atualizar quando o usuario clicar.
                        DataLoad();
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
