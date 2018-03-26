using TemperaturesDemo.Persistence;
using TemperaturesDemo.TemperatureProviders;

namespace TemperaturesDemo
{
    class ATestingProgram
    {
        static void ATestingMain(string[] args)
        {
            ITemperatureProvider providerToInject = new FakeTemperatureProvider();
            ITemperatureStore storeToInject = new MemoryTemperatureStore();

            // Manual, constructor dependency injection
            TemperatureManager temperatureManager = new TemperatureManager(providerToInject, storeToInject);

            temperatureManager.Update();
        }
    }
}