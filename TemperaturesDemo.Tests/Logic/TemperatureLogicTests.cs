using NUnit.Framework;
using TemperaturesDemo.Logic;

namespace TemperaturesDemo.Tests.Logic
{
    [TestFixture]
    class TemperatureLogicTests
    {
        [TestCase(-100, false)]
        [TestCase(-80, false)]
        [TestCase(-30, true)]
        [TestCase(0, true)]
        [TestCase(10, true)]
        [TestCase(20, true)]
        [TestCase(40, true)]
        [TestCase(100, false)]
        public void IsTemperatureValid_WithValidAndInvalidValues_ReturnsExpectedResults(double temperature, bool expected)
        {
            TemperatureLogic temperatureLogic = new TemperatureLogic();

            bool actual = temperatureLogic.IsTemperatureValid(temperature);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0.05, 0.1)]
        [TestCase(0.15, 0.2)]
        [TestCase(99.99, 100.0)]
        [TestCase(20.009, 20.0)]
        public void FormatTemperature_WithVariousLengthDecimals_ReturnsExpectedResults(double temperature, double expected)
        {
            TemperatureLogic temperatureLogic = new TemperatureLogic();

            double actual = temperatureLogic.FormatTemperature(temperature);

            Assert.AreEqual(expected, actual);
        }

    }
}