using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TemperaturesDemo.Models;
using TemperaturesDemo.Persistence;

namespace TemperaturesDemo.Tests.Persistence
{
    [TestFixture]
    class SqliteTemperatureStoreTests
    {
        [TestCase]
        public void GetCities_ReturnsNonEmptyResult()
        {
            SqliteTemperatureStore sqliteTemperatureStore = new SqliteTemperatureStore("Data Source=../../../TemperaturesDemo/TemperaturesDB.mdf");

            IEnumerable<City> cities = sqliteTemperatureStore.GetCities();

            Assert.Greater(cities.Count(), 0);
        }
    }
}