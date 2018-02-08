using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class FadeFilter : CameraFilter
    {
        public override string GetImage(string image)
        {
            return "Fade風格化後的" + image;
        }
    }
}