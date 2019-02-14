using System.Drawing;

namespace PhotoMaton
{
    internal class DoubleBinaire : IProcessing
    {

        public uint StepCount { get; set; } // count of steps done
        public Bitmap Image { get; set; } // image file

        public DoubleBinaire(Bitmap pImage)
        {
            this.Image = pImage;
        }

        public void DrawStep(uint step)
        {
            throw new System.NotImplementedException();
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
                    int X;
                    int Y;
                    if (x % 2 == 0)
                    {
                        X = x / 2;
                    }
                    else
                        X = Image.Width / 2 + x / 2;
                    if (y % 2 == 0)
                    {
                        Y = y / 2;
                    }
                    else
                    {
                        Y = Image.Height / 2 + y / 2;
                    }
                    tmp.SetPixel(X, Y, Image.GetPixel(x, y));
                }
            }
            this.Image = tmp;
            return Image;
        }
    }
}