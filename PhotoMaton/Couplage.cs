using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Couplage : IProcessing
    {
        public uint StepCount { get; set; }
        public Bitmap Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Couplage(Bitmap imageCouplage)
        {
            this.Image = imageCouplage;
        }

        public int ppcm(int a, int b)
        {
            int p = a * b;
            while (a != b) if (a < b) b -= a; else a -= b;
            return p / a;
        }

        public Bitmap Draw()
        {
            throw new NotImplementedException();
        }
    }
}
