using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    public interface IObserver
    {
        void Render(object sender, EventArgs e);
    }
}