using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class LomoFilter : CameraFilter
    {
        public override string GetImage(string image)
        {
            return "這是LOMO風格化後的" + image;
        }
    }
}