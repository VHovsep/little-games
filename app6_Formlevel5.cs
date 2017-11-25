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
    public partial class Formlevel5 : Form
    {
        int left_boxes;
        
        public Formlevel5()
        {
            InitializeComponent();
        }

        private void start_game4()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            left_boxes = 11;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box6.Visible = true;
            label_box7.Visible = true;
            label_box8.Visible = true;
            label_box9.Visible = true;
            label_box10.Visible = true;
            label_box11.Visible = true;
            label_box12.Visible = true;
            label_box13.Visible = true;
            label_box14.Visible = true;
            label_box15.Visible = true;
            label22.Visible = true;
            label20.Visible = false;
            label7.Visible = true;
            label5.Visible = false;
            label17.Visible = true;
            label23.Visible = false;
            sound.play_level5();
        }

        private void finish_game4()
        {
            sound.play_fail();
            DialogResult dr = MessageBox.Show("Game Over, Enter Now?", "messege",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game4();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game4();
        }

        private void Formlevel5_Shown(object sender, EventArgs e)
        {
            start_game4();
        }

        private void label_box1_MouseEnter(object sender, EventArgs e)
        {
            left_boxes--;
            ((Label)sender).Visible = false;
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label20.Visible = !label20.Visible;
            label22.Visible = !label22.Visible;
            label5.Visible = !label5.Visible;
            label7.Visible = !label7.Visible;
            label17.Visible = !label17.Visible; 
            label23.Visible = !label23.Visible;
        }
    }
}
