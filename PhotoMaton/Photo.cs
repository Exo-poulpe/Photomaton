using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMaton
{
    class Photo
    {
        const int DEFAULT_STEP_VALUE = 10;

        private string _path = default(string);

        public IProcessing Strategy { get; set; }
        public string Path { get => _path; private set => _path = value; }

        public Photo()
        {

        }

        public void Execute()
        {
            Strategy.DrawStep(DEFAULT_STEP_VALUE);
        }

        public void Execute(uint step)
        {
            Strategy.DrawStep(step);
        }





    }
}
