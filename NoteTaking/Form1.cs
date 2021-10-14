using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;

            dataGridView1.Columns["Title"].Width = 140;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBoxMessage.Text);

            textBox1.Clear();
            textBoxMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)

                textBox1.Text = table.Rows[index].ItemArray[0].ToString();

            textBoxMessage.Text = table.Rows[index].ItemArray[1].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
