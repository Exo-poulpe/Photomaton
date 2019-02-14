using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoMaton
{
    public partial class Form1 : Form
    {
        private const int BOULANGER_STEPS = 17;
        private const int DOUBLEBINAIRE_STEPS = 8;
        private const int PHOTOMATON_STEPS = 8;
        private const int INVERSE_STEP = 4;

        public Form1()
        {
            InitializeComponent();
            this.ouvrirToolStripMenuItem.Click += FileInput;
            this.photoMatonToolStripMenuItem.Click += PhotoMat;
        }

        public void FileInput(object sender,EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                string path = opf.FileName;
                Image img = Image.FromFile(path);
                pibImg.Image = img;

                if (img.Width % 2 == 1 || img.Height % 2 == 1)
                {
                    throw new Exception("The Width and Height of the image have to be even");
                }
            }

        }


        public void PhotoMat(object sender,EventArgs e)
        {
            Image img = pibImg.Image;
            Photomaton ph = new Photomaton(new Bitmap(img));
            for (int i = 0; i < PHOTOMATON_STEPS; i++)
            {
                pibImg.CreateGraphics().DrawImage(ph.Draw(), new Point(0, 0));
                img = pibImg.Image;
            }
        }

        private void twistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Image img = pibImg.Image;
            X myImageX = new X(new Bitmap(img));
            for (int i = 0; i < 128; i++)
            {
                pibImg.CreateGraphics().DrawImage(myImageX.Draw(img, pibImg), new Point(0, 0));
                img = myImageX.Image;
            }*/
        }

        private void boulangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pibImg.Image;
            Boulanger Boouboul = new Boulanger(new Bitmap(img));
            for (int i = 0; i < BOULANGER_STEPS; i++)
            {
                pibImg.CreateGraphics().DrawImage(Boouboul.Draw(), new Point(0, 0));
                img = Boouboul.Image;
            }

        }

        private void doubleBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pibImg.Image;
            DoubleBinaire doublebin = new DoubleBinaire(new Bitmap(img));
            for (int i = 0; i < DOUBLEBINAIRE_STEPS; i++)
            {
                pibImg.CreateGraphics().DrawImage(doublebin.Draw(), new Point(0, 0));
                img = doublebin.Image;
            }
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pibImg.Image;
            Inverse inv = new Inverse(new Bitmap(img));
            for (int i = 0; i < INVERSE_STEP; i++)
            {
                pibImg.CreateGraphics().DrawImage(inv.Draw(), new Point(0, 0));
                img = inv.Image;
                Thread.Sleep(100);
            }
        }

        private void swastikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
