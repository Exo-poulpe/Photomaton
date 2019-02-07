using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        public void FileInput(object sender,EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                string path = opf.FileName;
                Image img = Image.FromFile(path);
                this.CreateGraphics().DrawImage(img, new Point(0, 0));
            }
        }

        private void twistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Image.FromFile("C:\\Users\\Administrateur\\Downloads\\transfo\\joconde256.bmp"));
            X myImageX = new X(img);
            for (uint i = 0; i < 50; i++)
            {
                myImageX.DrawStep(i);
            }
            
            
        }
    }
}
