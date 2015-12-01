using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay _currentDisplay = new CurrentConditionDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);

            weatherData.SetMeasurements(70, 62, 35.4f);
        }
    }
}
