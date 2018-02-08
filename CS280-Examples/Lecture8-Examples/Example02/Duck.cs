using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Duck
    {
        public string Name { get; set; }
        private IFlyBehavior FlyBehavior;

        public void Fly()
        {
            if (FlyBehavior == null)
                Console.WriteLine("我不會飛");
            else
                FlyBehavior.Fly();
        }

        public void Equip(IFlyBehavior item)
        {
            this.FlyBehavior = item;
        }
    }
}