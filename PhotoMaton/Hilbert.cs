using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Hilbert : IProcessing
    {
        private Bitmap _image;
        private uint _stepCount;

        private int cpt = 0; private int ind = 0;
        private int pow;
        private int dy;
        private int dx;
        private int y;
        private int x;
        private int ta;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap Image { get => _image; set => _image = value; }



        public void calcul_matrice()
        {
            int size = this.Image.Width;
            int i = 0;
            for (;size > 2;i++)
            {
                size /= 2;
            }


            forme(1, i);

            addCycle(mc);
        }

        public void trace(int nx, int ny)
        {
            dx = (x + nx * ta);
            dy = (y + ny * ta);
            setVal(0, 0, ind, cpt++);
            mc.addPoint(new Point(dx, dy));


            x = dx;
            y = dy;
        }

        public void u(int i)
        {
            switch (i)
            {
                case 1:
                    trace(0, 1); trace(1, 0); trace(0, -1);
                    break;
                case 2:
                    trace(1, 0); trace(0, 1); trace(-1, 0);
                    break;
                case 3:
                    trace(-1, 0); trace(0, -1); trace(1, 0);
                    break;
                case 4:
                    trace(0, -1); trace(-1, 0); trace(0, 1);
                    break;
            }

        }


        public void forme(int i, int n)
        {
            if (n == 0)
            {
                u(i);
            }
            else
            {
                switch (i)
                {
                    case 1:
                        forme(2, n - 1); trace(0, 1);
                        forme(1, n - 1); trace(1, 0);
                        forme(1, n - 1); trace(0, -1);
                        forme(3, n - 1);
                        break;
                    case 2:
                        forme(1, n - 1); trace(1, 0);
                        forme(2, n - 1); trace(0, 1);
                        forme(2, n - 1); trace(-1, 0);
                        forme(4, n - 1);
                        break;
                    case 3:
                        forme(4, n - 1); trace(-1, 0);
                        forme(3, n - 1); trace(0, -1);
                        forme(3, n - 1); trace(1, 0);
                        forme(1, n - 1);
                        break;
                    case 4:
                        forme(3, n - 1); trace(0, -1);
                        forme(4, n - 1); trace(-1, 0);
                        forme(4, n - 1); trace(0, 1);
                        forme(2, n - 1);
                        break;
                }
            }
        }

        public Boolean estPossible()
        {
            int he = this.Image.Height;
            int wi = this.Image.Width;
            he = he <= wi ? he : wi;
            pow = 1;
            while (he > 1)
            {
                he /= 2;
                pow <<= 1;
            }

            return (pow == this.Image.Height) && (pow == wi);
        }
        
        public Bitmap Draw()
        {
            throw new NotImplementedException();
        }
    }
}
