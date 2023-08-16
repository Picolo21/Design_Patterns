using DesignPatterns.FactoryMethod.Vehicles;

namespace DesignPatterns.FactoryMethod.Factories
{
    public class BicycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bicycle();
        }
    }
}
