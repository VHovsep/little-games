using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void Box_Sound_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_Sound.Checked)
            {
                sound.sound_on();
                Box_Sound.Text = "ZVUK ON";
                sound.play_key();
            }
            else
            {
                sound.sound_off();
                Box_Sound.Text = "ZVUK OFF";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_level1()
        {
            Formlevel1 level1 = new Formlevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level2();
        }

        private void start_level2()
        {
            Formlevel2 level2 = new Formlevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level3();
        }

        private void start_level3()
        {
            Formlevel3 level3 = new Formlevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level4();
        }

        private void start_level4()
        {
            Formlevel4 level4 = new Formlevel4();
            DialogResult dr = level4.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level5();
        }

        private void start_level5()
        {
            Formlevel5 level5 = new Formlevel5();
            DialogResult dr = level5.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level6();
        }

        private void start_level6()
        {
            Formlevel6 level6 = new Formlevel6();
            DialogResult dr = level6.ShowDialog();
            if(dr==System.Windows.Forms.DialogResult.OK)
            {
                start_youwin();
            }
        }

        private void start_youwin()
        {
            sound.play_youwin();
            MessageBox.Show("YOU WIN");
        }
    }
}
