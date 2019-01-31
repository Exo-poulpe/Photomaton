using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoMaton
{
    class Photomaton : IProcessing
    {

        private uint _stepCount = 0;
        private Bitmap _image = null;
        
        public uint StepCount { get => _stepCount; set => _stepCount = value; }
        public Bitmap Image { get => _image; set => _image = value; }

        public Photomaton(Bitmap img)
        {
            this.Image = img;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void DrawStep(uint step)
        {
            Bitmap resized = new Bitmap(Image, new Size(Image.Size.Width / 2, Image.Size.Height / 2));
            resized.Save(@"C:\Users\Administrateur\Pictures\std\test.jpg");
            throw new NotImplementedException();
        }
    }
}
