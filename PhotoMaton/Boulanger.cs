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

        public uint StepCount { get; set; } // count of steps done
        public Bitmap Image { get; set; } // image file

        public Boulanger(Bitmap pImage)
        {
            this.Image = pImage;
        }

        public Bitmap Draw()
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
            
            return Image;
        }

    }
}
