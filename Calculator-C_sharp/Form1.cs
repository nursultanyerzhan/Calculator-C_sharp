using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_C_sharp
{
    public partial class Form1 : Form
    {
        String st = "";
        double a, b, c, d;
        double a1,b11,d1;
        char z;
        bool q, q0;
        bool q1 = false;
        public Form1()
        {
            InitializeComponent();

        }
        

        public void ten()
        {
            q = textBox1.Text.Equals("");
            if (!q)
            {
                b = Convert.ToDouble(textBox1.Text);
                b11 = b;
                switch (z)
                {
                    case '+': d = a + b; break;
                    case '-': d = a - b; break;
                    case '*': d = a * b; break;
                    case '/': d = a / b; break;
                    case '^': d = Math.Pow(a, b); break;
                    case 'm': d = a % b; d1 = a1 / b11; MessageBox.Show(" Бөлінді мәні: " + Convert.ToString(d1)); break;
                    default: d = 0; break;
                }
                textBox1.Text = Convert.ToString(d);
                label1.Text = label1.Text + Convert.ToString(b) + " = " + textBox1.Text;

            }
        }
        private void b1_Click(object sender, EventArgs e)
        {

            {
                q0 = textBox1.Text.Equals("0");
                if (q0)
                {
                    st = "";
                    textBox1.Text = "";
                }
                st = textBox1.Text; // for ( -/+ )
                st = st + "1";
                textBox1.Text = st;
            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "2";
            textBox1.Text = st;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "3";
            textBox1.Text = st;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "4";
            textBox1.Text = st;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "5";
            textBox1.Text = st;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "6";
            textBox1.Text = st;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text;
            st = st + "7";
            textBox1.Text = st;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "8";
            textBox1.Text = st;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "9";
            textBox1.Text = st;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            q0 = textBox1.Text.Equals("0");
            if (q0)
            {
                st = "";
                textBox1.Text = "";
            }
            st = textBox1.Text; // for ( -/+ )
            st = st + "0";
            textBox1.Text = st;
        }
        private void br_Click(object sender, EventArgs e)
        {
            ten();
            q1 = false;
            listBox1.Items.Add(label1.Text);
            textBox1.Focus();
            
        }
        int ch;
        private void bn_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("");
            ch = textBox1.Text.IndexOf(",");
            if (q)
            {
                st = st + "0,";
                textBox1.Text = st;
            }
            else
            {
                if (ch == (-1))
                {
                    st = textBox1.Text;
                    st = st + ",";
                    textBox1.Text = st;
                }
            }
        }

        private void bp_Click(object sender, EventArgs e)
        {
            if (!q1)
            {
                label1.Text = textBox1.Text + " + ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '+';
                }
                else textBox1.Text = "0";
            }
            else
            {
                ten();
                label1.Text = textBox1.Text + " + ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '+';
                }
                else textBox1.Text = "0";

            }
            q1 = true;
            textBox1.Focus();
        }

        private void bm_Click(object sender, EventArgs e)
        {
            if (!q1)
            {
                label1.Text = textBox1.Text + " - ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '-';
                }
                else textBox1.Text = "0";
            }
            else
            {
                ten();
                label1.Text = textBox1.Text + " - ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '-';
                }
                else textBox1.Text = "0";
            }
            textBox1.Focus();
            q1 = true;
        }

        private void bk_Click(object sender, EventArgs e)
        {
            if (!q1)
            {
                label1.Text = textBox1.Text + " * ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '*';
                }
                else textBox1.Text = "0";
            }
            else
            {
                ten();
                label1.Text = textBox1.Text + " * ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '*';
                }
                else textBox1.Text = "0";
            }
            q1 = true;
            textBox1.Focus();
        }

        private void bb_Click(object sender, EventArgs e)
        {
            if (!q1)
            {
                label1.Text = textBox1.Text + " / ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '/';
                }
                else textBox1.Text = "0";
            }
            else
            {
                ten();
                label1.Text = textBox1.Text + " / ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = '/';
                }
                else textBox1.Text = "0";
            }
            q1 = true;
            textBox1.Focus();
        }

        private void C_Click(object sender, EventArgs e)
        {
            st = "0";
            textBox1.Text = st;
            a = b = c = d = 0;
            label1.Text = "History";
            listBox1.Items.Add("Отчисление");
            q1 = false;
        }

        private void pm_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                c = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + " * ( -1 ) = ";
                c = c * (-1);
                textBox1.Text = Convert.ToString(c);
                label1.Text = label1.Text + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "sin( ";
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin(d));
                label1.Text = "sin( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos(d));
                label1.Text = "cos( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan(d));
                label1.Text = "tan( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!groupBox2.Visible)
            {
                groupBox2.Visible = true;
                this.button4.Text = "<=";

            }
            else if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
                this.button4.Text = "=>";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Asin(d));
                label1.Text = "Asin( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Acos(d));
                label1.Text = "Acos( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Atan(d));
                label1.Text = "Atan( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Log(d));
                label1.Text = "log( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Log10(d));
                label1.Text = "ln( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Exp(d));
                label1.Text = "exp( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(d));
                label1.Text = "sqrt( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " ^ ";
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                st = "0";
                z = '^';
            }
            else textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                double n = 1;
                st = textBox1.Text;
                for (int i = 1; i <= Convert.ToDouble(textBox1.Text); i++)
                {
                    n *= i;
                }
                textBox1.Text = Convert.ToString(n);
                label1.Text = st + "! = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 2));
                label1.Text = "sqr( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {
            /* if (button4.)
             {
                 textBox1.Location = Point(12,12);
             }*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Round(d));

                label1.Text = "Round( " + Convert.ToString(d) + " ) = " + textBox1.Text;
                d = Convert.ToDouble(textBox1.Text);
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Abs(d));
                label1.Text = "Abs( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            q = textBox1.Text.Equals("0");
            if (!q)
            {
                d = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), (0.333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333)));
                label1.Text = "X^(1/3) ( " + Convert.ToString(d) + " ) = " + textBox1.Text;
            }
            else textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Visible = true;
                checkBox1.Text = "Disable Mathematical expressions";

            }
            else
            {
                groupBox2.Visible = false;
                checkBox1.Text = "Enable Mathematical expressions";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private bool pc(int n)
        {
            bool qw = false;
            for (int i = 2; i <= n / 2; i++ )
            {
                if (n % i == 0)
                {
                    qw = true;
                }
            }
            return qw;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (pc(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("Құрама сан!");
            }
            else
            {
                MessageBox.Show("Жай сан!");
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            if (!q1)
            {
                label1.Text = textBox1.Text + " mod ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    a1 = a;
                    textBox1.Text = "";
                    st = "";
                    z = 'm';
                }
                else textBox1.Text = "0";
            }
            else
            {
                ten();
                label1.Text = textBox1.Text + " mod ";
                q = textBox1.Text.Equals("0");
                if (!q)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    st = "";
                    z = 'm';
                }
                else textBox1.Text = "0";

            }
            q1 = true;
            textBox1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (pc(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("Құрама сан!");
            }
            else
            {
                MessageBox.Show("Жай сан!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int pcbol(int n)
        {
            int bolindi = 0; 
            for (int i = 2; i < n ; i++)
            {
                if (n % i == 0)
                {
                    bolindi = i;
                    break;
                }
            }
            return bolindi;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            int rr = pcbol(Convert.ToInt32(textBox1.Text));
            if (rr != 0)
            {
                MessageBox.Show(Convert.ToString(rr));
            }
            else
            {
                MessageBox.Show("Жай сан!");
            }
        }
        private string pcbolw(int n)
        {
            int bolindi = 0;
            string astr = "";
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    bolindi = i;

                    if (!pc(bolindi))
                    {
                        astr = astr + " " + Convert.ToString(bolindi);
                    }
                }
            }
            return astr;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text = pcbolw(Convert.ToInt32(textBox1.Text));
        }
        
        private void button23_Click(object sender, EventArgs e)
        {
            int P, Q, N, phi, E, phi2, E2;
            string cstr;
            P = 4211;
            Q = 3863;
            N = P * Q;
            phi = Convert.ToInt32(textBox6.Text);
            phi2 = phi;
            E = Convert.ToInt32(textBox7.Text);
            E2 = E;
            cstr = Convert.ToString(phi / E);
            textBox1.Text = cstr;
            label7.Text = Convert.ToString(phi) + "=" + Convert.ToString(E) + "*" + cstr+ "+" + Convert.ToString(phi % E);
            textBox2.Text = label7.Text.Substring(0,label7.Text.IndexOf('='));
            label7.Text = label7.Text.Remove(0, label7.Text.IndexOf('=') + 1);

            textBox3.Text = label7.Text.Substring(0, label7.Text.IndexOf('*'));
            label7.Text = label7.Text.Remove(0, label7.Text.IndexOf('*') + 1);
            
            textBox4.Text = label7.Text.Substring(0, label7.Text.IndexOf('+'));
            label7.Text = label7.Text.Remove(0, label7.Text.IndexOf('+') + 1);

            textBox5.Text = label7.Text;

        }
        string qi = "";
        string pi11 = "";
        string pi12 = "";
        int pi ;
        int pi1 = 1;
        int pi2 = 0;
        int D;
        private void button25_Click(object sender, EventArgs e)
        {
            label8.Text = textBox2.Text + "=" + textBox3.Text + "*" + textBox4.Text + "+" + textBox5.Text ;
            listBox2.Items.Add(label8.Text);
            textBox6.Text = textBox3.Text;
            textBox7.Text = textBox5.Text;
            qi = textBox4.Text;
            pi = Convert.ToInt32(textBox4.Text) * pi1 + pi2;
            pi11 = Convert.ToString(pi1);
            pi12 = Convert.ToString(pi2);
            pi2 = pi1;
            pi1 = pi;
            textBox1.Text = Convert.ToString(pi);
            label11.Text = Convert.ToString(pi) + "=" + Convert.ToString(pi11) + "*" + Convert.ToString(textBox4.Text) + "+" + Convert.ToString(pi12);
            
            listBox3.Items.Add(label11.Text);
            if (label8.Text.Equals("1"))
            {
                D = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(textBox1.Text);
            }

                
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            int j = 0;
            string str = "";
            for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
            {
                if (vpcbool(i))
                {

                    str +=" " + Convert.ToString(i);
                    //j++;
                }
            }
            
            //button28.Text = Convert.ToString(vpc(Convert.ToInt32(textBox1.Text)));
            button28.Text = str;
        }

        private int vpc(int n)
        {
            int vpch = 0 ;
            for (int i = 1; i <= n; i++)
            {
                if (!pc(i) && n % i != 0)
                {
                    vpch++;
                }
            }
            return vpch;
        }

        private bool vpcbool(int n)
        {
            bool vpch = false;
            for (int i = 1; i <= n; i++)
            {
                if (!pc(i) && n % i != 0)
                {
                    vpch = true;
                }
            }
            return vpch;
        }

    }
}
