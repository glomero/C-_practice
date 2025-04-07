using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, This is my first c sharp code!!!");
            MessageBox.Show("1");
            MessageBox.Show("2");
            MessageBox.Show("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Im button 2!!!");        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Im button 3!!!","Hello");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button2.BackColor = Color.Green;
            this.BackColor = Color.Red;
            button4.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Im textbox!!!";
            this.button3.Text = "Hi Babe!!!";
            this.Text = "Hi I love you, Me too!!!";
        }
    }
}
