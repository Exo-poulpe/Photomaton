using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoMaton
{
    class Inverse : IProcessing
    {

        private uint _stepCount = 0;

        private Bitmap _image;

        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap Image { get => _image; set => _image = value; }

        public Inverse(Bitmap img)
        {
            Image = img;
        }

        public Bitmap Draw()
        {
            Image flip = this.Image;
            flip.RotateFlip(RotateFlipType.Rotate180FlipX);
            this.Image = new Bitmap(flip);
            return this.Image;
        }
    }
}
