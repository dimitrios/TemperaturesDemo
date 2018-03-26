using System.Collections.Generic;
using System.Linq;
using TemperaturesDemo.Models;

namespace TemperaturesDemo.Persistence
{
    public class MemoryTemperatureStore : ITemperatureStore
    {
        private List<CityTemperature> cityTemperatures = new List<CityTemperature>();

        public MemoryTemperatureStore()
        {
            cityTemperatures.Add(new CityTemperature("Athens", "gr", 0));
            cityTemperatures.Add(new CityTemperature("Valetta", "mt", 0));
            cityTemperatures.Add(new CityTemperature("Dublin", "ir", 0));
        }

        public IEnumerable<City> GetCities()
        {
            return cityTemperatures.Select(ct => new City(ct.Name, ct.Country));
        }

        public void UpdateCityTemperature(City city, double temperature)
        {
            cityTemperatures.Where(ct => (ct.Name == city.Name) && (ct.Country == city.Country)).First().Temperature = temperature;
        }

        private class CityTemperature : City
        {
            public double Temperature { get; set; }

            public CityTemperature(string name, string country, double temperature) : base(name, country)
            {
                this.Temperature = temperature;
            }
        }
    }
}