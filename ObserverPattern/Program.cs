using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternClassLibrary;

namespace ObserverPatternImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather = new WeatherData();
            CurrentConditionDisplay display1 = new CurrentConditionDisplay(weather);
            weather.SetMeasurements(80, 65, 30.4F);
            weather.SetMeasurements(82, 70, 30.4F);
            weather.SetMeasurements(78, 90, 30.4F);
            Console.ReadKey();
        }
    }
}
