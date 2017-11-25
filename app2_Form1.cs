using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int i;//qayler@ hashvox@
        int num_game = 0;//xaxi hamar@
        int Ovin;//0-i haxtanakneri qanak@
        int Xvin;//X-i haxtanakneri qanak@
        String[] arr = new string[10];//masiv,vortex pahvum en X-ern u 0-ner@ xaxi mej
        string t = "X";//popoxakan,vor@ cuyc e talis um qayli hetn e

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        public string Game(int j)//@ndunum e vandaki hamar@
        {
            string faket;//hajord qayli popoxakan@
            if (i % 2 == 1)//hashvum e vor(um) qayln e katarvel
            {
                t = "X";
                faket = "0";
            }
            else
            {
                t = "0";
                faket = "X";
            }
            faket = "qayl e anum" + faket;
            arr[j] = t;
            i += 1;

            textBox1.Text=faket;//grum e umn e hajord qayl@

            return t;
        }

        public void who_vin()
        {
            if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") |
                (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") |
                (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") |
                (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
            {//es depqerum haxtuma X-@
                Xvin += 1;
                textBox3.Text = "X:O\n" + Xvin.ToString() + ":" + Ovin.ToString();//tarmacnum enq haxtanakneri hartak@
                MessageBox.Show("X VIN!");
                refresch();//0-jacnum enq xax@,sksum noric
            }
            if ((arr[1] == "0" & arr[2] == "0" & arr[3] == "0") | (arr[1] == "0" & arr[5] == "0" & arr[9] == "0") |
               (arr[1] == "0" & arr[4] == "0" & arr[7] == "0") | (arr[2] == "0" & arr[5] == "0" & arr[8] == "0") |
               (arr[3] == "0" & arr[6] == "0" & arr[9] == "0") | (arr[3] == "0" & arr[5] == "0" & arr[7] == "0") |
               (arr[4] == "0" & arr[5] == "0" & arr[6] == "0") | (arr[7] == "0" & arr[8] == "0" & arr[9] == "0"))
            {//es depqerum haxtuma X-@
                Xvin += 1;
                textBox3.Text = "X:O\n" + Xvin.ToString() + ":" + Ovin.ToString();//tarmacnum enq haxtanakneri hartak@
                MessageBox.Show("0 VIN!");
                refresch();//0-jacnum enq xax@,sksum noric
            }
            if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
            {//nichya
                MessageBox.Show("nichya");
                refresch();
            }
        }
            public void refresch()
            {
                button1.Text="";
                button2.Text="";
                button3.Text="";
                button4.Text="";
                button5.Text="";
                button6.Text="";
                button7.Text="";
                button8.Text="";
                button9.Text="";
                textBox1.Text="";
                for(i=0;i<10;i++)
                {
                    arr[i]="";
                }
                i=1;//qayli hamar@
                num_game+=1;//xaxi hamar@
                textBox2.Text=num_game + "sksecinq";
            }

        private void button10_Click(object sender, EventArgs e)
        {
            refresch();
        }
         private void button1_Click(object sender, EventArgs e)
        {
             if(button1.Text == "X"| button1.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button1.Text = Game(1);
                 who_vin();
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if(button2.Text == "X"| button2.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button2.Text = Game(2);
                 who_vin();
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if(button3.Text == "X"| button3.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button3.Text = Game(3);
                 who_vin();
             }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             if(button4.Text == "X"| button4.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button4.Text = Game(4);
                 who_vin();
             }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             if(button5.Text == "X"| button5.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button5.Text = Game(5);
                 who_vin();
             }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             if(button6.Text == "X"| button6.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button6.Text = Game(6);
                 who_vin();
             }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             if(button7.Text == "X"| button7.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button7.Text = Game(7);
                 who_vin();
             }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             if(button8.Text == "X"| button8.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button8.Text = Game(8);
                 who_vin();
             }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             if(button9.Text == "X"| button9.Text == "0")//ete arden lracvac e
             {
                 MessageBox.Show("zbaxvac e");//naxazgushacnum e vor chi kareli
             }
             else{
                 button9.Text = Game(9);
                 who_vin();
             }
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            refresch();//datarkum enq xaxic araj
            textBox3.Text="X:0\n" + Xvin.ToString() + ":" + Ovin.ToString();//ashxatacnum enq shyotchik@
        }
    }
}
