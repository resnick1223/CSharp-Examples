using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10___Observer_Pattern
{
    public interface IObserver
    {
        void Render(Object sender, EventArgs e);
    }
}