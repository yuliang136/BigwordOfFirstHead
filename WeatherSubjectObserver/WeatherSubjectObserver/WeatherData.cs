using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSubjectObserver
{
    class WeatherData : ISubject
    {
        private List<IObserver> _ltObservers;

        private float _fTemperature;
        private float _fHumidity;
        private float _fPressure;
        public void NotifyObservers()
        {
            foreach (IObserver observer in _ltObservers)
            {
                observer.Update(_fTemperature, _fHumidity, _fPressure);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _ltObservers.Remove(o);
        }

        public void RegisterObserver(IObserver o)
        {
            _ltObservers.Add(o);
        }

        public WeatherData()
        {
            _ltObservers = new List<IObserver>();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _fTemperature = temperature;
            _fHumidity = humidity;
            _fPressure = pressure;

            MeasurementsChanged();
        }
    }
}
