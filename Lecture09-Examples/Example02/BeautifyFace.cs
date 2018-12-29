using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class BeautifyFace : Plugin, IFilter
    {
        public BeautifyFace()
        {
            Name = "美顏相機";
        }

        public string ApplyFilter(string image)
        {
            if (image.IndexOf("人臉") < 0)
                return image;
            else
                return "美顏 " + image;
        }
    }
}