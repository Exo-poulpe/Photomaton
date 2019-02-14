/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 *
using System.Drawing;
using System.Windows.Forms;

namespace PhotoMaton
{
    class X : IProcessing
    {
        public uint StepCount { get; set; }
        public Bitmap Image { get; set; }

        public X(Bitmap imageX)
        {
            this.Image = imageX;
        }

        //En X Pour chaque pixel, si son numéro de ligne est pair, on l'augmente de 2, 
        //s'il est impair on le diminue de 2. Même chose pour la colonne.
        //Contrainte de taille d'image :hauteur et largeur paires. Période : ppcm(larg/2, haut/2)
        public void DrawStep(uint step)
        {
            for (int x = 0; x < step; x++)
            {
                for (int y = 0; y < step; y++)
                {
                    if (x % 2 == 0 && y % 2 == 0)
                    {
                        Image.GetPixel(x + 2, y + 2);
                    }
                    else
                    {
                        Image.GetPixel(x - 2, y - 2);
                    }
                }
            }

        }
        public Point Next(Point p)
        {
            int y;
            int x;
            int largeur = Image.Size.Width / 2;
            int longueur = Image.Size.Height / 2;

            if ((p.X % 2 == 0) && (p.Y % 2 == 0))
            {
                x = (p.X + 2) % largeur;
                y = (p.Y + 2) % longueur;
            }
            else
            {
                if ((p.X % 2 == 1) && (p.Y % 2 == 0))
                {
                    if (p.X - 2 < 0)
                    {
                        x = largeur + (p.X - 2);
                    }
                    else
                    {
                        x = p.X - 2;
                    }
                    y = (p.Y + 2) % longueur;
                }
                else
                {
                    if ((p.X % 2 == 0) && (p.Y % 2 == 1))
                    {
                        if (p.Y - 2 < 0)
                        {
                            y = longueur + (p.Y - 2);
                        }
                        else
                        {
                            y = p.Y - 2;
                        }
                        x = (p.X + 2) % largeur;
                    }
                    else
                    {
                        if (p.Y - 2 < 0)
                        {
                            y = longueur + (p.Y - 2);
                        }
                        else
                        {
                            y = p.Y - 2;
                        }

                        if (p.X - 2 < 0)
                        {
                            x = largeur + (p.X - 2);
                        }
                        else
                        {
                            x = p.X - 2;
                        }
                    }
                }
            }
            return new Point(x, y);
        }

        public Bitmap Draw(Image img, PictureBox pib)
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
                    p = Next(new Point(i, j));
                    New.SetPixel(p.X, p.Y, resized.GetPixel(i, j));
                }
            }
            pib.Image = New;
            return New;
        }
    }
}*/