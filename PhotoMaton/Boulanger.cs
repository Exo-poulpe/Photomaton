/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    class Boulanger : IProcessing
    {

        public uint StepCount { get; set; } // count of steps done
        public Bitmap img { get; set; } // image file

        public Boulanger(Bitmap pImage)
        {
            this.img = pImage;
        }

        public Bitmap Draw(Bitmap img)
        {
            Bitmap tmp = img;

                tmp = new Bitmap(img.Width, img.Height);
                //tmp2 = new Bitmap(Image.Width*2, Image.Height*2);
                for (int x = 0; x < this.img.Width; x++)
                {
                    for (int y = 0; y < this.img.Height; y++)
                    {
                        if ((y % 2 == 0) && (x < this.img.Width / 2))
                        {
                            tmp.SetPixel(2 * x, y / 2, this.img.GetPixel(x, y));
                        }
                        else if ((y % 2 != 0) && (x < this.img.Width / 2))
                        {
                            tmp.SetPixel(2 * x + 1, (y - 1) / 2, this.img.GetPixel(x, y));
                        }
                        else if ((y % 2 == 0) && (x >= this.img.Width / 2))
                        {
                            tmp.SetPixel(2 * this.img.Width - 1 - 2 * x, this.img.Height - 1 - y / 2, this.img.GetPixel(x, y));
                        }
                        else if ((y % 2 != 0) && (x >= this.img.Width / 2))
                        {
                            tmp.SetPixel(2 * this.img.Width - 2 - 2 * x, this.img.Height - 1 - (y - 1) / 2, this.img.GetPixel(x, y));
                        }

                        //Image.GetPixel(i, j);// a faire : https://fr.wikipedia.org/wiki/Transformation_du_boulanger
                    }
                }
                this.img = tmp;
            
            return this.img;
        }

    }
}
