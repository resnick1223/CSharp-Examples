using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    public interface ISubject
    {
        void Register(IObserver o);

        void Remove(IObserver o);

        void Notify();
    }
}