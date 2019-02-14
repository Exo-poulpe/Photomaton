/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    class Inverse : IProcessing
    {

        private uint _stepCount = 0;

        private Bitmap _image;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap img { get => _image; set => _image = value; }

        public Inverse(Bitmap img)
        {
            this.img = img;
        }

        public Bitmap Draw(Bitmap pImage)
        {
            Image flip = this.img;
            flip.RotateFlip(RotateFlipType.Rotate180FlipX);
            this.img = new Bitmap(flip);
            return this.img;
        }
    }
}
