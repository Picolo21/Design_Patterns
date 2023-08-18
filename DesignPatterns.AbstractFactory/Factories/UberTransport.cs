using DesignPatterns.AbstractFactory.Aircrafts;
using DesignPatterns.AbstractFactory.LandVehicles;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Car();
        }
    }
}
