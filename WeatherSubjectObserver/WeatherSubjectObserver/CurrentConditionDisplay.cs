using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    class CurrentConditionDisplay : IObserver,IDisplayElement
    {
        private float _fTemperature;
        private float _fHumidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _fTemperature + "F degress and "
                              + _fHumidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _fTemperature = temp;
            _fHumidity = humidity;

            Display();
        }
    }
}
