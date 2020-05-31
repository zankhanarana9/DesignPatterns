using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClassLibrary
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}
