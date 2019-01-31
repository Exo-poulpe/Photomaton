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

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void DrawStep(uint step)
        {
            throw new NotImplementedException();
        }
    }
}
