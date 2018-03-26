using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturesDemo.TemperatureProviders
{
    /// <summary>
    /// Uses openweathermap.org's API to provide temperatures
    /// </summary>
    public class OpenWeatherMapTemperatureProvider : ITemperatureProvider
    {
        public OpenWeatherMapTemperatureProvider(string apiKey)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends a request to openweathermap.org's API and returns the temperature for the given city
        /// </summary>
        public double GetTemperature(string city, string country)
        {
            // Hint:
            // http://api.openweathermap.org/data/2.5/weather?q=Athens,gr&appid=YOUR-API-KEY-HERE&units=imperial
            throw new NotImplementedException();
        }
    }
}