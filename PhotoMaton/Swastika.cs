/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    class Swastika : IProcessing
    {
        private uint _stepCount;
        private Bitmap _image;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap img { get => _image; set => _image = value; }

        public Swastika(Bitmap pImage)
        {
            this.img = pImage;
        }

        public Bitmap Draw(Bitmap img)
        {
            Bitmap tmp = img;
            tmp = new Bitmap(this.img.Width, this.img.Height);
            for (int x = 0; x < this.img.Width; x++)
            {
                for (int y = 0; y < this.img.Height; y++)
                {
                    int col = x;
                    int lig = y;
                    int l = this.img.Width / 2;
                    int h = this.img.Height / 2;

                    if ((x % 2 == 0) && (y % 2 == 0))
                    {
                        col = x / 2;
                        lig = y / 2;
                    }
                    else if ((x % 2 == 1) && (y % 2 == 0))
                    {
                        col = (x - 1) / 2 + l;
                        lig = y / 2;


                        int milCol = 3 * l / 2;
                        int milLig = h / 2;
                        int colR = col - milCol;
                        int ligR = milLig - lig;
                        int c = ligR; int li = -colR;
                        col = milCol + c;
                        if (this.img.Width / 2 % 2 == 0)
                        {
                            col--;
                        }
                        lig = milLig - li;
                    }
                    else if ((x % 2 == 0) && (y % 2 == 1))
                    {
                        col = x / 2;
                        lig = (y - 1) / 2 + h;


                        int milCol = l / 2;
                        int milLig = 3 * h / 2;
                        int colR = col - milCol;
                        int ligR = milLig - lig;
                        int c = -ligR; int li = colR;
                        col = milCol + c;
                        lig = milLig - li;
                        if (this.img.Height / 2 % 2 == 0)
                        {
                            lig--;
                        }
                    }
                    else
                    {
                        col = (x - 1) / 2 + l;
                        lig = (y - 1) / 2 + h;

                        int milieu = 3 * h / 2;
                        col += 2 * (milieu - col);
                        if (this.img.Width / 2 % 2 == 0)
                        {
                            col--;
                        }
                        milieu = 3 * l / 2;
                        lig += 2 * (milieu - lig);
                        if (this.img.Height / 2 % 2 == 0)
                        {
                            lig--;
                        }
                    }
                    tmp.SetPixel(lig, col, this.img.GetPixel(x, y));
                }
            }

            this.img = tmp;
            return this.img;
            //return new Point(col, lig);
        }
    }
}
