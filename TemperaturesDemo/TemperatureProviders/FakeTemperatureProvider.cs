namespace TemperaturesDemo.TemperatureProviders
{
    public class FakeTemperatureProvider : ITemperatureProvider
    {
        public double GetTemperature(string city, string country)
        {
            return 25;
        }
    }
}