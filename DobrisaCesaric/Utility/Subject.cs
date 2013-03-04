using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.Utility
{
    public class Subject
    {
        private List<IObserver> _listObservers = new List<IObserver>();

        public void addObserver(IObserver inObs)
        {
            _listObservers.Add(inObs);
        }

        public void notifyObservers()
        {
            foreach (IObserver obs in _listObservers)
                obs.update();
        }
    }
}

