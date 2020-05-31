using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClassLibrary
{
    public class WeatherData : Subject
    {
        public  float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public List<Observer> observers;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
     
        public void  MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
