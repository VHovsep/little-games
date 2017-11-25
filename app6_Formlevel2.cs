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
    public partial class Formlevel2 : Form
    {
        public Formlevel2()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = label_start1.Location;
            point.Offset(label_start1.Width / 2, label_start1.Height / 2);
            Cursor.Position = PointToScreen(point);
            label25.Visible = true;
            label26.Visible = true;
            sound.play_start();
        }

        private void finish_game()
        {
            sound.play_fail();
            DialogResult dr = MessageBox.Show("Game Over, Enter Now?", "messege",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void Formlevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            label25.Visible = false;
            sound.play_key();
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            if (label25.Visible)
                finish_game();
            else
            {
                label26.Visible = false;
                sound.play_key();
            }
        }

        private void label_finish1_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
