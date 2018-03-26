using System;

namespace TemperaturesDemo.Logic
{
    public class TemperatureLogic
    {
        public double FormatTemperature(double temperature)
        {
            return Math.Round(temperature, 1, MidpointRounding.AwayFromZero);
        }

        public bool IsTemperatureValid(double temperature)
        {
            return ((temperature > -60) && (temperature < 60));
        }
    }
}