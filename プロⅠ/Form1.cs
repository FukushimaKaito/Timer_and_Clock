using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 12;
            label1.Text = x.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x =0;
            label1.Text = x.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}