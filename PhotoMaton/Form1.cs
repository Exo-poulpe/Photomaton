﻿using System;
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
            }

        }


        public void PhotoMat(object sender,EventArgs e)
        {
            Image img = pibImg.Image;
            Photomaton ph = new Photomaton(new Bitmap(img));
            for (int i = 0; i < 8; i++)
            {
                pibImg.CreateGraphics().DrawImage(ph.Draw(img, pibImg), new Point(0, 0));
                img = pibImg.Image;
            }
        }

        private void twistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pibImg.Image;
            X myImageX = new X(new Bitmap(img));
            for (int i = 0; i < 100; i++)
            {
                pibImg.CreateGraphics().DrawImage(myImageX.Draw(img, pibImg), new Point(0, 0));
                img = myImageX.Image;
            }


        }

        private void boulangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pibImg.Image;
            Boulanger Boouboul = new Boulanger(new Bitmap(img));
            for (int i = 0; i < 17; i++)
            {
                pibImg.CreateGraphics().DrawImage(Boouboul.Draw(), new Point(0, 0));
                img = Boouboul.Image;
            }

        }
    }
}
