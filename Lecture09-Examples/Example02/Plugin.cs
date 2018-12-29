using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public abstract class Plugin
    {
        public string Name { get; set; }
        public bool Enabled = false;
    }
}