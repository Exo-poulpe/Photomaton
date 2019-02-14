/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    class Photomaton : IProcessing
    {

        private uint _stepCount = 0;
        private Bitmap _image = null;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap img { get => _image; set => _image = value; }

        public Photomaton(Bitmap img)
        {
            this.img = img;
        }

        private Point CalcPoint(Point p)
        {
            int l = img.Size.Width / 2;
            int h = img.Size.Height / 2;
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

        public Bitmap Draw(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;
            Bitmap resized = img;
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
            //this.Image = New;
            return New;
        }
    }
}
