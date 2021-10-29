using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int beigeHorse, whiteHorse, greyHorse;
        Random asd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int widthBeige = pictureBox1.Width;
            int widthWhite = pictureBox2.Width;
            int widthGrey = pictureBox3.Width;
            int start = label4.Left;

            pictureBox1.Left = pictureBox1.Left + asd.Next(5, 18);
            pictureBox2.Left = pictureBox2.Left + asd.Next(5, 18);
            pictureBox3.Left = pictureBox3.Left + asd.Next(5, 18);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "Beige leads the race";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "White takes the lead";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left +5)
            {
                label7.Text = "Grey is ahead of them";
            }


            if (widthBeige + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
                label7.Text = "The Beige Horse Won The Race!";
            }

            if (widthWhite + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label7.Text = "The White Horse Won The Race!";
            }

            if (widthGrey + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label7.Text = "The Grey Horse Won The Race!";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beigeHorse = pictureBox1.Left;
            whiteHorse = pictureBox2.Left;
            greyHorse = pictureBox3.Left;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
