using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        double t1 = 0;
        double t2 = 0;
        bool plus = false;
        bool minus = false;
        bool mul = false;
        bool divide = false;

        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(".")==false)
            {
              //  this.textBox1.Text = textBox1.Text + ".";
                this.textBox1.Text = textBox1.Text + button13.Text;
            }
            else
            {
                MessageBox.Show("Decimal Already Exists");       
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button2.Text;
          //  this.textBox1.Text = textBox1.Text + "1";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button4.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button7.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button6.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button10.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(plus==true)
            {
                t2 = t1 + double.Parse(textBox1.Text);
                textBox1.Text = t2.ToString();
                t1 = 0;
            }
            else if(minus==true)
            {
                t2 = t1 - double.Parse(textBox1.Text);
                textBox1.Text = t2.ToString();
                t1 = 0;
            }
            else if (mul == true)
            {
                t2 = t1 * double.Parse(textBox1.Text);
                textBox1.Text = t2.ToString();
                t1 = 0;
            }
            else if (divide == true)
            {
                t2 = t1 / double.Parse(textBox1.Text);
                textBox1.Text = t2.ToString();
                t1 = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t1 += double.Parse(textBox1.Text);
            // t1= t1 * double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = false;
            minus = false;
            mul = false;
            divide = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            t1 += double.Parse(textBox1.Text);
          // t1= t1 + double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = false;
             minus = false;
             mul = true;
             divide = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            t1 += double.Parse(textBox1.Text);
            // t1= t1 * double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = false;
            minus = true;
            mul = false;
            divide = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t1 += double.Parse(textBox1.Text);
            // t1= t1 + double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = true;
            minus = false;
            mul = false;
            divide = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.BackColor = Color.LightCyan;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
