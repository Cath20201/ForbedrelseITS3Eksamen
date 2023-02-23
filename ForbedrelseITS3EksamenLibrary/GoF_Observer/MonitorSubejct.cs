using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class MonitorSubejct
    {
        private readonly List<IDataObserver> _observers = new List<IDataObserver>();

        public void Attach(IDataObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IDataObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
