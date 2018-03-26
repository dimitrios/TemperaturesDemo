using System.Collections.Generic;
using TemperaturesDemo.Models;

namespace TemperaturesDemo.Persistence
{
    /// <summary>
    /// A temperature store
    /// </summary>
    public interface ITemperatureStore
    {
        /// <summary>
        /// Returns all the cities in store
        /// </summary>
        IEnumerable<City> GetCities();

        /// <summary>
        /// Updates the temperature for the given city in store
        /// </summary>
        void UpdateCityTemperature(City city, double temperature);
    }
}