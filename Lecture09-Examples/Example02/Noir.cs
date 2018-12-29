using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class Noir : Filter
    {
        public Noir()
        {
            Name = "復古";
        }

        public override string ApplyFilter(string image)
        {
            return "加上復古風色調 " + image;
        }
    }
}