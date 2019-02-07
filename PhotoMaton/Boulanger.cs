using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Boulanger : IProcessing
    {
        private const int STEP_AMOUNT = 17;

        public uint StepCount { get; set; } // count of steps done
        public Bitmap Image { get; set; } // image file

        public Boulanger(Bitmap pImage)
        {
            this.Image = pImage;
        }

        public void DrawStep(uint step)
        {
            Bitmap tmp = default(Bitmap);

            tmp = new Bitmap(Image.Width, Image.Height);
            //tmp2 = new Bitmap(Image.Width*2, Image.Height*2);
            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    if ((y % 2 == 0) && (x < Image.Width / 2))
                    {
                        tmp.SetPixel(2 * x, y / 2, Image.GetPixel(x, y));
                    }
                    else if ((y % 2 != 0) && (x < Image.Width / 2))
                    {
                        tmp.SetPixel(2 * x + 1, (y - 1) / 2, Image.GetPixel(x, y));
                    }
                    else if ((y % 2 == 0) && (x >= Image.Width / 2))
                    {
                        tmp.SetPixel(2 * Image.Width - 1 - 2 * x, Image.Height - 1 - y / 2, Image.GetPixel(x, y));
                    }
                    else if ((y % 2 != 0) && (x >= Image.Width / 2))
                    {
                        tmp.SetPixel(2 * Image.Width - 2 - 2 * x, Image.Height - 1 - (y - 1) / 2, Image.GetPixel(x, y));
                    }

                    //Image.GetPixel(i, j);// a faire : https://fr.wikipedia.org/wiki/Transformation_du_boulanger
                }
            }
            this.Image = tmp;
            //return this.Image;
        }

        public Bitmap Draw()
        {
            if (Image.Width % 2 == 1 || Image.Height % 2 == 1)
            {
                throw new Exception("The Width and Height of the image have to be even");
            }
            Bitmap tmp = default(Bitmap);
            //Bitmap tmp2 = default(Bitmap);
            for (int i = 0; i < 1; i++)
            {

                tmp = new Bitmap(Image.Width, Image.Height);
                //tmp2 = new Bitmap(Image.Width*2, Image.Height*2);
                for (int x = 0; x < Image.Width; x++)
                {
                    for (int y = 0; y < Image.Height; y++)
                    {
                        if ((y % 2 == 0) && (x < Image.Width / 2))
                        {
                            tmp.SetPixel(2 * x, y / 2, Image.GetPixel(x, y));
                        }
                        else if ((y % 2 != 0) && (x < Image.Width / 2))
                        {
                            tmp.SetPixel(2 * x + 1, (y - 1) / 2, Image.GetPixel(x, y));
                        }
                        else if ((y % 2 == 0) && (x >= Image.Width / 2))
                        {
                            tmp.SetPixel(2 * Image.Width - 1 - 2 * x, Image.Height - 1 - y / 2, Image.GetPixel(x, y));
                        }
                        else if ((y % 2 != 0) && (x >= Image.Width / 2))
                        {
                            tmp.SetPixel(2 * Image.Width - 2 - 2 * x, Image.Height - 1 - (y - 1) / 2, Image.GetPixel(x, y));
                        }

                        //Image.GetPixel(i, j);// a faire : https://fr.wikipedia.org/wiki/Transformation_du_boulanger
                    }
                }
                this.Image = tmp;
            }
            return tmp;
        }

    }
}
