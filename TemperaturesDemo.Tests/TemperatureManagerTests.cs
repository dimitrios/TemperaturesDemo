using NUnit.Framework;
using TemperaturesDemo.Persistence;
using TemperaturesDemo.TemperatureProviders;

namespace TemperaturesDemo.Tests
{
    [TestFixture]
    public class TemperatureManagerTests
    {
        [TestCase]
        public void Update_DoesNotThrowException()
        {
            // Create a test provider and store
            ITemperatureProvider provider = new FakeTemperatureProvider();
            ITemperatureStore store = new MemoryTemperatureStore();

            // Inject the test dependencies
            TemperatureManager testTemperatureManager = new TemperatureManager(provider, store);

            Assert.DoesNotThrow(() => testTemperatureManager.Update());
        }
    }
}