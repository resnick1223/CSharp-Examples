using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10___Observer_Pattern
{
    public interface IObservable
    {
        void Register(IObserver o);

        void Remove(IObserver o);

        void Notify();
    }
}