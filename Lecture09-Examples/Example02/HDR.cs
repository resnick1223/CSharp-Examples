using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class HDR : Plugin, IFilter
    {
        public HDR()
        {
            Name = "HDR";
        }

        public string ApplyFilter(string image)
        {
            return "HDR " + image;
        }
    }
}