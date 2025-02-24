using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacNurse_sProject
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTable adicionarForm = new AddTable();
            adicionarForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveItem removeItem = new RemoveItem();
            removeItem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit();
            Edit.Show();
        }
    }
}
