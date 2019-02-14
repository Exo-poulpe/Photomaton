using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Swastika : IProcessing
    {
        private uint _stepCount;
        private Bitmap _image;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap Image { get => _image; set => _image = value; }

        public Swastika(Bitmap pImage)
        {
            this.Image = pImage;
        }

        public Bitmap Draw()
        {
            Bitmap tmp = default(Bitmap);
            tmp = new Bitmap(Image.Width, Image.Height);
            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    int col = x;
                    int lig = y;
                    int l = Image.Width / 2;
                    int h = Image.Height / 2;

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
                        if (Image.Width / 2 % 2 == 0)
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
                        if (Image.Height / 2 % 2 == 0)
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
                        if (Image.Width / 2 % 2 == 0)
                        {
                            col--;
                        }
                        milieu = 3 * l / 2;
                        lig += 2 * (milieu - lig);
                        if (Image.Height / 2 % 2 == 0)
                        {
                            lig--;
                        }
                    }
                    tmp.SetPixel(lig, col, Image.GetPixel(x, y));
                }
            }

            this.Image = tmp;
            return this.Image;
            //return new Point(col, lig);
        }
    }
}
