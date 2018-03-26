using System.Collections.Generic;
using TemperaturesDemo.Logic;
using TemperaturesDemo.Models;
using TemperaturesDemo.Persistence;
using TemperaturesDemo.TemperatureProviders;

namespace TemperaturesDemo
{
    public class TemperatureManager
    {
        TemperatureLogic logic = new TemperatureLogic();
        ITemperatureProvider provider;
        ITemperatureStore store;

        public TemperatureManager()
        {
            // Local defaults
            this.provider = new YahooTemperatureProvider();
            this.store = new SqliteTemperatureStore("Data Source=../../TemperaturesDB.mdf");
        }

        public TemperatureManager(ITemperatureProvider temperatureProvider, ITemperatureStore temperatureStore)
        {
            // Injected dependencies
            this.provider = temperatureProvider;
            this.store = temperatureStore;
        }

        public void Update()
        {
            IEnumerable<City> cities = store.GetCities();

            foreach (City aCity in cities)
            {
                // Format and if within valid range, save
                double temperature = logic.FormatTemperature(provider.GetTemperature(aCity.Name, aCity.Country));
                if (logic.IsTemperatureValid(temperature))
                {
                    store.UpdateCityTemperature(aCity, temperature);
                }
            }
        }
    }
}