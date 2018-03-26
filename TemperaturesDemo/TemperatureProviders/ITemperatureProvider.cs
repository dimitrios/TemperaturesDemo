namespace TemperaturesDemo.TemperatureProviders
{
    /// <summary>
    /// A temperature provider
    /// </summary>
    public interface ITemperatureProvider
    {
        /// <summary>
        /// Returns the temperature for the given city
        /// </summary>
        double GetTemperature(string city, string country);
    }
}