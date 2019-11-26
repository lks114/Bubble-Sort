using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSorter
{
    public partial class Form1 : Form
    {
        const int MAX = 9;
        int[] hgt = new int[MAX];
        PictureBox[] pboxes = new PictureBox[9];

        public Form1()
        {
            InitializeComponent();
            btnSort.Enabled = false;
        }

        private void btn_Initialize_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            int tmpHgt;

            pboxes[1] = pictureBox1;
            pboxes[2] = pictureBox2;
            pboxes[3] = pictureBox3;
            pboxes[4] = pictureBox4;
            pboxes[5] = pictureBox5;
            pboxes[6] = pictureBox6;
            pboxes[7] = pictureBox7;
            pboxes[8] = pictureBox8;


            for (int ctr = 1; ctr <= 8; ctr++)
            {     
                // randmize 8 numbers
                tmpHgt = (Byte)rnd.Next(6, 15);
                // multiply by 15, these will be used as heights of the picture boxes
                pboxes[ctr].Height = tmpHgt * 15;
                pboxes[ctr].BackColor = Color.DarkBlue;
            }
            btnSort.Enabled = true;
          }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort bubble = new BubbleSort();
            bubble.Sort(pboxes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}