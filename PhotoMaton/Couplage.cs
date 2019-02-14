/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System;
using System.Drawing;

namespace PhotoMaton
{
    class Couplage : IProcessing
    {
        public uint StepCount { get; set; }
        public Bitmap img { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Couplage(Bitmap imageCouplage)
        {
            this.img = imageCouplage;
        }

        public int ppcm(int a, int b)
        {
            int p = a * b;
            while (a != b) if (a < b) b -= a; else a -= b;
            return p / a;
        }

        public Bitmap Draw(Bitmap img)
        {
           return img;
        }
    }
}
