using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace BubbleSorter
{
    static class BuubleSort
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            BubbleSort Bubble = new BubbleSort();         
        }
    }

    class BubbleSort
    {
        const int MAX = 9;
        int max = MAX;
      
        public void Sort(PictureBox[] pboxes)
        {
            String runStatus = "Initial";
            int tmpHgt;

            while (runStatus != "Done")
            {
                runStatus = "Initial";
                for (int i = 1; i < max - 1; i++)
                {                    
                    pboxes[i].BackColor = Color.Orange;
                    pboxes[i + 1].BackColor = Color.Orange;
                    MessageBox.Show("Comparing");
                   
                    if (pboxes[i].Height > pboxes[i + 1].Height)
                    {
                        runStatus = "Switch";
                        tmpHgt = pboxes[i + 1].Height;
                        pboxes[i + 1].Height = pboxes[i].Height;
                        pboxes[i].Height = tmpHgt;
                        pboxes[i].BackColor = Color.Red;
                        pboxes[i + 1].BackColor = Color.Red;
                        MessageBox.Show("Switching");

                    }
                    pboxes[i].BackColor = Color.DarkBlue;
                    pboxes[i + 1].BackColor = Color.DarkBlue;                   
                }
                if (runStatus.Equals("Initial"))
                {
                    runStatus = "Done";
                    MessageBox.Show("Done!");
                }
            }
        }  
    }
       
}
