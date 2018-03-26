namespace TemperaturesDemo.Models
{
    public class City
    {
        public string Name { get; private set; }
        public string Country { get; private set; }

        public City(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }
    }
}
