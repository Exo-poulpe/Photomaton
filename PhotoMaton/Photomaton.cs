using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace PhotoMaton
{
    class Photomaton : IProcessing
    {

        private uint _stepCount = 0;
        private Bitmap _image = null;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap Image { get => _image; set => _image = value; }

        public Photomaton(Bitmap img)
        {
            this.Image = img;
        }

        public void DrawStep(uint step)
        {
            Bitmap resized = new Bitmap(Image, new Size(Image.Size.Width / 4, Image.Size.Height / 4));


        }

        private Point CalcPoint(Point p)
        {
            int l = Image.Size.Width / 2;
            int h = Image.Size.Height / 2;
            int x = default(int);
            int y = default(int);

            for (int i = 0; i < 4; i++)
            {
                if ((p.X % 2 == 0) && (p.Y % 2 == 0))
                {
                    x = p.X / 2;
                    y = p.Y / 2;
                }
                else
                {
                    if ((p.X % 2 == 1) && (p.Y % 2 == 0))
                    {
                        x = (p.X - 1) / 2 + l;
                        y = p.Y / 2;
                    }
                    else
                    {
                        if ((p.X % 2 == 0) && (p.Y % 2 == 1))
                        {
                            x = p.X / 2;
                            y = (p.Y - 1) / 2 + h;
                        }
                        else
                        {
                            x = (p.X - 1) / 2 + l;
                            y = (p.Y - 1) / 2 + h;
                        }
                    }
                }
            }

            return new Point(x, y);
        }

        public Bitmap Draw(Image img,PictureBox pib )
        {
            int w = img.Width;
            int h = img.Height;
            Bitmap resized = new Bitmap(img);
            Bitmap New = new Bitmap(256, 256);
            Point p = default(Point);

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    p = CalcPoint(new Point(i, j));
                    New.SetPixel(p.X, p.Y, resized.GetPixel(i, j));
                }
            }
            pib.Image = New;
            Thread.Sleep(1000);
            return New;
        }
    }
}
