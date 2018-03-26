using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace TemperaturesDemo.TemperatureProviders
{
    /// <summary>
    /// Uses Yahoo's Weather API to provide temperatures
    /// </summary>
    public class YahooTemperatureProvider : ITemperatureProvider
    {
        HttpClient httpClient = new HttpClient();
        string protocol = "https";

        /// <summary>
        /// Sends a request to Yahoo's weather API and returns the temperature for the given city
        /// </summary>
        public double GetTemperature(string city, string country)
        {
            // Construct the yahoo url
            Uri requestUri = new Uri(String.Format("{2}://query.yahooapis.com/v1/public/yql?q=select * from weather.forecast " +
                "where woeid in (select woeid from geo.places(1) where text=\"{0}, {1}\") and u=\"c\"&format=json&env=store://datatables.org/alltableswithkeys",
                city, country, protocol));
            // Get temperatures
            dynamic response = JsonConvert.DeserializeObject(httpClient.GetStringAsync(requestUri).Result);

            return (double)response.query.results.channel.item.condition.temp;
        }
        /// <summary>
        /// Sets the protocol to communicate with Yahoo's API to "Http"
        /// </summary>
        public void UseHttp()
        {
            this.protocol = "http";
        }
        /// <summary>
        /// Sets the protocol to communicate with Yahoo's API to "Https"
        /// </summary>
        public void UseHttps()
        {
            this.protocol = "https";
        }
    }
}