using DesignPatterns.AbstractFactory.Aircrafts;
using DesignPatterns.AbstractFactory.LandVehicles;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Motorcycle();
        }
    }
}
