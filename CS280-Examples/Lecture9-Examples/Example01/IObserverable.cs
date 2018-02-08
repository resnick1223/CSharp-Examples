using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface IObserverable
    {
        void Register(IObserver o);

        void RemoveObserver(IObserver o);

        void Notify();
    }
}