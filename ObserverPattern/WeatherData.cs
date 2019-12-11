using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static ObserverPattern.WeatherInterfaces;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++) {
                IObserver observer = (IObserver)observers.get(i);
            }
        }
    }
}
