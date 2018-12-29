using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public abstract class Props
    {
        public string Name { get; set; }
        public Player player = new Player();
    }
}