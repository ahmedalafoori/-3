using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace اله_حاسبة3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x, z, y;
        char c;

        private void button2_Click(object sender, EventArgs e)
        {
            Resulte.Clear();
           // x = Convert.ToInt32(Resulte.Text);
            //Resulte.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Resulte.TextLength >0)
            {
                string s = Resulte.Text;
                Resulte.Clear();
                Resulte.Text = s.Remove(s.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToSingle(Resulte.Text);
            z = 1;
            for(int i = 1; i <=x; i++)
            {
                z = z * i;
            }
           Resulte.Text=Convert.ToString(z);
        }

        private void button16_Click(object sender, EventArgs e)
        {  
            x = Convert.ToSingle(Resulte.Text);
            Resulte.Clear();
            c = '/';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToSingle(Resulte.Text);
            Resulte.Clear();
            c = '+';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "6";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToSingle(Resulte.Text);
            Resulte.Clear();
            c = '-';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "1";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text +"2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text +"3";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            x = Convert.ToSingle(Resulte.Text);
            Resulte.Clear();
            c = '*';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(Resulte.TextLength > 0)
            {
                Resulte.Text =Convert.ToString(Convert.ToSingle(Resulte.Text) * -1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Resulte.Text = Resulte.Text + ".";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            y = Convert.ToSingle(Resulte.Text);
            switch(c)
            {
                case'+':
                    z = x + y;
                    break;
                case'-':
                    z = x - y;
                    break;
                case'*':
                    z = x * y;
                    break;
                case '/':
                    z = x / y;
                    break;
            }
            Resulte.Text=z.ToString();
        }
    }
}
