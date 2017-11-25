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
    public partial class Formlevel6 : Form
    {
        int left_boxes;

        public Formlevel6()
        {
            InitializeComponent();
        }

        private void start_game5()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label_val1.Visible = true;
            label_val2.Visible = false;
            label_val3.Visible = true;
            label_val4.Visible = true;
            label_val5.Visible = false;
            label_val6.Visible = true;
            label_val7.Visible = false;
            label_val8.Visible = true;
            label_val9.Visible = true;
            label_val10.Visible = false;
            left_boxes = 5;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            sound.play_level6();
        }

        private void finish_game5()
        {
            sound.play_fail();
            DialogResult dr = MessageBox.Show("Game Over, Enter Now?", "messege",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game5();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish_game5();
        }

        private void Formlevel6_Shown(object sender, EventArgs e)
        {
            start_game5();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if(left_boxes == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_val1.Visible = !label_val1.Visible;
            label_val2.Visible = !label_val2.Visible;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label_val5.Visible = !label_val5.Visible;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label_val3.Visible = !label_val3.Visible;
            label_val4.Visible = !label_val4.Visible;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label_val6.Visible = !label_val6.Visible;
            label_val7.Visible = !label_val7.Visible;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label_val8.Visible = !label_val8.Visible;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label_val9.Visible = !label_val9.Visible;
            label_val10.Visible = !label_val10.Visible;
        }

        private void label_box1_MouseEnter(object sender, EventArgs e)
        {
            left_boxes--;
            ((Label)sender).Visible = false;
        }
    }
}
