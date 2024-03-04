using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302223025
{
    public partial class Form1 : Form
    {
        public int num1, num2,temp, hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
           //textBox1.Show();
            Console.Write(textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            //textBox1.Show();

           Console.Write(textBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            Console.Write(textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            Console.Write(textBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            Console.Write(textBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            Console.Write(textBox1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            Console.Write(textBox1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            Console.Write(textBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            Console.Write(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            Console.Write(textBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = 0;
            num2 = 0;
            hasil = num1 + num2;
            textBox1.Text = Convert.ToString(hasil);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = 0;
            temp = Convert.ToInt32(textBox1.Text);
            num1 += temp;
            textBox1.Clear();
        }
    }
}
