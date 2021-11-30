using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "s";
            string password = "s";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("НЕТ");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
           }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}