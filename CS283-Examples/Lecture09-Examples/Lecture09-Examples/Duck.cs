using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    public class Duck
    {
        public string Name { get; set; }
        public IFlyable FlyBehavior;

        public Duck 裝上可飛行的道具(Object obj)
        {
            if (obj is IFlyable)
                FlyBehavior = obj as IFlyable;
            else
                Console.WriteLine("裝備的物件，不具有飛行能力，無法安裝");
            return this;
        }

        public Duck 脫下裝備()
        {
            Console.WriteLine("脫下裝備");
            FlyBehavior = null;
            return this;
        }

        public Duck 飛行()
        {
            if (FlyBehavior == null)
                Console.WriteLine("未裝有任何具有飛行能力的道具，所以不會飛");
            else
                FlyBehavior.Fly();

            return this;
        }
    }
}