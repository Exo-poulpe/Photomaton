using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Point next(Point p)
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
    }
}
