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
    public partial class Formlevel3 : Form
    {

        int left_boxes;

        public Formlevel3()
        {
            InitializeComponent();
        }


        private void start_game2()
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
            label_box5.Visible = true;
            label_box6.Visible = true;
            label_box7.Visible = true;
            label_box8.Visible = true;
            label_box9.Visible = true;
            label_box10.Visible = true;
            label_box11.Visible = true;
            sound.play_level3();
        }

        private void finish_game2()
        {
            sound.play_fail();
            DialogResult dr = MessageBox.Show("Game Over, Enter Now?", "messege",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game2();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void Formlevel3_Shown(object sender, EventArgs e)
        {
            start_game2();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            finish_game2();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if(left_boxes == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label_box1_MouseEnter(object sender, EventArgs e)
        {
            left_boxes--;
            ((Label)sender).Visible = false;
        }
    }
}
