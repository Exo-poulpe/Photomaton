/*
 * Author: Santos, Troller, Juling
 * Date: 14.02.2019
 * Class: T.IS-E2B
 * Version: 1.0
 */
using System.Drawing;

namespace PhotoMaton
{
    interface IProcessing
    {
        uint StepCount { get; set; }
        Bitmap img { get; set; }
        Bitmap Draw(Bitmap pImage);
    }
}
