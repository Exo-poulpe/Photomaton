/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    internal class DoubleBinaire : IProcessing
    {

        public uint StepCount { get; set; } // count of steps done
        public Bitmap img { get; set; } // image file

        public DoubleBinaire(Bitmap pImage)
        {
            this.img = pImage;
        }

        public void DrawStep(uint step)
        {
            throw new System.NotImplementedException();
        }
        public Bitmap Draw(Bitmap img)
        {
            Bitmap tmp = img;

            tmp = new Bitmap(this.img.Width, this.img.Height);
            //tmp2 = new Bitmap(Image.Width*2, Image.Height*2);
            for (int x = 0; x < this.img.Width; x++)
            {
                for (int y = 0; y < this.img.Height; y++)
                {
                    int X;
                    int Y;
                    if (x % 2 == 0)
                    {
                        X = x / 2;
                    }
                    else
                        X = this.img.Width / 2 + x / 2;
                    if (y % 2 == 0)
                    {
                        Y = y / 2;
                    }
                    else
                    {
                        Y = this.img.Height / 2 + y / 2;
                    }
                    tmp.SetPixel(X, Y, this.img.GetPixel(x, y));
                }
            }
            this.img = tmp;
            return this.img;
        }
    }
}