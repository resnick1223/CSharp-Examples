using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface IObserver
    {
        void UpdateView(object sender, EventArgs e);
    }
}