using NUnit.Framework;
using TemperaturesDemo.TemperatureProviders;

namespace TemperaturesDemo.Tests.TemperatureProviders
{
    [TestFixture]
    class YahooTemperatureProviderTests
    {
        [TestCase("Athens", "gr")]
        [TestCase("Valetta", "mt")]
        [TestCase("Dublin", "ir")]
        public void GetTemperature_DoesNotThrowException(string city, string country)
        {
            YahooTemperatureProvider yahooTemperatureProvider = new YahooTemperatureProvider();
            
            Assert.DoesNotThrow(() => yahooTemperatureProvider.GetTemperature(city, country));
        }
    }
}