using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherInterfaces
    {
        public interface ISubject
        {
            void registerObserver(IObserver o);
            void removeObserver(IObserver o);
            void notifyObservers();
        }

        public interface IObserver
        {
            public void update(float temp, float humidity, float pressure);
        }

        public interface IDisplayElement
        {
            void display();
        }
    }
}
