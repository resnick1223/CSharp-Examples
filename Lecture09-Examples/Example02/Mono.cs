using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class Mono : Filter
    {
        public Mono()
        {
            Name = "黑白";
        }

        public override string ApplyFilter(string image)
        {
            return "加上黑白色調 " + image;
        }
    }
}