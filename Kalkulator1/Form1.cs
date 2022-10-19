using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Untuk Mengkosongkan data
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Untuk Mengecek data kosong atau tidak
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Anda belum mengisi angka 1 dan 2 !!");
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a + b;
                this.hasil.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Untuk Mengecek data kosong atau tidak
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Anda belum mengisi angka 1 dan 2 !!");
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a - b;
                this.hasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Untuk Mengecek data kosong atau tidak
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Anda belum mengisi angka 1 dan 2 !!");
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a * b;
                this.hasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Untuk Mengecek data kosong atau tidak
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Anda belum mengisi angka 1 dan 2 !!");
            }
            else
            {
                int a, b, c;

                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a / b;
                this.hasil.Text = c.ToString();
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
