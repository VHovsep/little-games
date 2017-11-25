using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int cash = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void dvig1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l1.Text = System.Convert.ToString(dig);
        }

        private void dvig2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l2.Text = System.Convert.ToString(dig);
        }

        private void dvig3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l3.Text = System.Convert.ToString(dig);
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            cash = cash - 5;
            label_cash.Text = System.Convert.ToString(cash);
            dvig1.Enabled = true;
            dvig2.Enabled = true;
            dvig3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dvig1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dvig2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            dvig3.Enabled = false;
            stop3.Enabled = false;

            if ((l1.Text == "1") && (l2.Text == "1"))
            {
                if (l3.Text != "1")
                {
                    MessageBox.Show("duq haxtel eq 100$ ");
                    cash += 100;
                }
            }
            if ((l1.Text == "2") && (l2.Text == "2"))
            {
                if (l3.Text != "2")
                {
                    MessageBox.Show("duq haxtel eq 200$ ");
                    cash += 200;
                }
            }
            if ((l1.Text == "3") && (l2.Text == "3"))
            {
                if (l3.Text != "3")
                {
                    MessageBox.Show("duq haxtel eq 300$ ");
                    cash += 300;
                }
            }
            if ((l1.Text == "4") && (l2.Text == "4"))
            {
                if (l3.Text != "4")
                {
                    MessageBox.Show("duq haxtel eq 400$ ");
                    cash += 400;
                }
            }
            if ((l1.Text == "5") && (l2.Text == "5"))
            {
                if (l3.Text != "5")
                {
                    MessageBox.Show("duq haxtel eq 500$ ");
                    cash += 500;
                }
            }
            if ((l1.Text == "6") && (l2.Text == "6"))
            {
                if (l3.Text != "6")
                {
                    MessageBox.Show("duq haxtel eq 600$ ");
                    cash += 600;
                }
            }
            if ((l1.Text == "7") && (l2.Text == "7"))
            {
                if (l3.Text != "7")
                {
                    MessageBox.Show("duq haxtel eq 700$ ");
                    cash += 700;
                }
            }
            if ((l1.Text == "8") && (l2.Text == "8"))
            {
                if (l3.Text != "8")
                {
                    MessageBox.Show("duq haxtel eq 800$ ");
                    cash += 800;
                }
            }
            if ((l1.Text == "1") && (l2.Text == "1") && (l3.Text == "1"))
            {
                MessageBox.Show("duq haxtel eq 1000$ ");
                cash += 1000;
            }
            if ((l1.Text == "2") && (l2.Text == "2") && (l3.Text == "2"))
            {
                MessageBox.Show("duq haxtel eq 5000$ ");
                cash += 5000;
            }
            if ((l1.Text == "3") && (l2.Text == "3") && (l3.Text == "3"))
            {
                MessageBox.Show("duq haxtel eq 10000$ ");
                cash += 10000;
            }
            if ((l1.Text == "4") && (l2.Text == "4") && (l3.Text == "4"))
            {
                MessageBox.Show("duq haxtel eq 20000$ ");
                cash += 20000;
            }
            if ((l1.Text == "5") && (l2.Text == "5") && (l3.Text == "5"))
            {
                MessageBox.Show("duq haxtel eq 40000$ ");
                cash += 40000;
            }
            if ((l1.Text == "6") && (l2.Text == "6") && (l3.Text == "6"))
            {
                MessageBox.Show("duq haxtel eq 60000$ ");
                cash += 60000;
            }
            if ((l1.Text == "7") && (l2.Text == "7") && (l3.Text == "7"))
            {
                MessageBox.Show("duq haxtel eq 100000$ ");
                cash += 100000;
            }
            if ((l1.Text == "8") && (l2.Text == "8") && (l3.Text == "8"))
            {
                MessageBox.Show("duq haxtel eq 250000$ ");
                cash += 250000;
            }
            if ((l1.Text == "7") || (l2.Text == "7") || (l3.Text == "7"))
            {
                MessageBox.Show("duq haxtel eq 50$ ");
                cash += 50;
            }
            label_cash.Text = System.Convert.ToString(cash);
        }
    }
}
