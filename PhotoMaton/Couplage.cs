using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Couplage : IProcessing
    {
        public uint StepCount { get; set; }
        public string Path { get ; set; }

        public Couplage(string filePath)
        {
            this.Path = filePath;
        }

        public int ppcm(int a, int b)
        {
            int p = a * b;
            while (a != b) if (a < b) b -= a; else a -= b;
            return p / a;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void DrawStep(int step)
        {
            throw new NotImplementedException();
        }
    }
}
