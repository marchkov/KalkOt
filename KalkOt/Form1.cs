using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkOt
{
    public partial class Form1 : Form
    {
        public double mnoz;
        public double x;
        public double y;
        public double delka;
        public double nadavek;
        public double resalt;
        public double cOt;
        public double dOt;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") mnoz = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "") x = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text != "") y = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text != "") delka = Convert.ToDouble(textBox4.Text);
            if (textBox5.Text != "") nadavek = Convert.ToDouble(textBox5.Text);

            if (mnoz>0 && x>0 && y > 0 && delka > 0 && nadavek > 0)
                cOt = mnoz / (x * y);
                dOt = nadavek / (delka / 1000);
                resalt = Math.Ceiling(cOt + dOt);
                label8.Text = Convert.ToString(resalt);
                label9.Text = Convert.ToString(Math.Ceiling(cOt * (delka / 1000)));
                label10.Text = Convert.ToString(Math.Ceiling((cOt + dOt) * (delka / 1000)));
            
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
