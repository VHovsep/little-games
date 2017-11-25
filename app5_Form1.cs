using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        int secret_nr = 0;
        int secret_nr_1 = 0;
        int secret_nr_2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1;
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            if (secret_nr_2 == 2)
                this.BackgroundImage = Properties.Resources.secret_2;
            else
                this.BackgroundImage = Properties.Resources._2;
            secret_nr_2 = 0;
        }

        private void buttonShow3_Click(object sender, EventArgs e)
        {
            if (secret_nr_1 == 2)
                this.BackgroundImage = Properties.Resources.secret_1;
            else
                this.BackgroundImage = Properties.Resources._3;
            secret_nr_1 = 0;
        }

        private void buttonShow4_Click(object sender, EventArgs e)
        {
            if(secret_nr == 2)
                this.BackgroundImage = Properties.Resources.secret;
            else
                this.BackgroundImage = Properties.Resources._4;
            secret_nr = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                secret_nr = 1;
                secret_nr_1 = 1;
                secret_nr_2 = 1;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (secret_nr == 1)
                if (e.X < buttonShow1.Location.X &&
                    e.Y < buttonShow1.Location.Y)
                    secret_nr = 2;
            if (secret_nr_1 == 1)
                if (e.X < buttonShow2.Location.X &&
                    e.Y < buttonShow2.Location.Y)
                    secret_nr_1 = 2;
            if (secret_nr_2 == 1)
                if (e.X < buttonShow3.Location.X &&
                    e.Y < buttonShow3.Location.Y)
                    secret_nr_2 = 2;
        }
    }
}
