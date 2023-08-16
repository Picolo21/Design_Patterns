using DesignPatterns.FactoryMethod.Vehicles;

namespace DesignPatterns.FactoryMethod.Factories
{
    public class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
