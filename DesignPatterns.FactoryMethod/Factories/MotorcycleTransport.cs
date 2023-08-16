using DesignPatterns.FactoryMethod.Vehicles;

namespace DesignPatterns.FactoryMethod.Factories
{
    public class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
