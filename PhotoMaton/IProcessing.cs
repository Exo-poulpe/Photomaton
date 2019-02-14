using System.Drawing;

namespace PhotoMaton
{
    interface IProcessing
    {
        uint StepCount { get; set; }
        Bitmap Image { get; set; }
        Bitmap Draw(Bitmap pImage);
    }
}
