using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            label2.BackColor = Color.Chocolate;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
            label2.BackColor = Color.Gray;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
        }
    }
}
