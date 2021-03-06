using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            if (Name.Equals(""))
            {
                MessageBox.Show("Ban can nhap ten!");
                textBox1.Focus();
                return;
            }
            string Age = textBox2.Text;
            if (Age.Equals(""))
            {
                MessageBox.Show("Ban can nhap tuoi");
                textBox2.Focus();
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ban can chon phong ban!");
                comboBox1.Focus();
                return;
            }

        }
    }
}
