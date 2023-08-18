using DesignPatterns.AbstractFactory.Aircrafts;
using DesignPatterns.AbstractFactory.LandVehicles;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Scooter();
        }
    }
}
