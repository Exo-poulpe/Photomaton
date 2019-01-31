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
        private string _path = string.Empty;

        private uint _stepCount = 0;

        public string Path { get => _path; set => _path = value; }
        public uint StepCount { get => _stepCount; set => _stepCount = value; }

        public Photomaton(string filePath)
        {
            this.Path = filePath;
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
