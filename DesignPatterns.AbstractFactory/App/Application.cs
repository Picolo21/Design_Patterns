using DesignPatterns.AbstractFactory.Aircrafts;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.LandVehicles;

namespace DesignPatterns.AbstractFactory.App
{
    public class Application
    {
        private readonly IAircraft _aircraftFactory;
        private readonly ILandVehicle _landVehicleFactory;

        public Application(ITransportFactory factory)
        {
            _aircraftFactory = factory.CreateTransportAircraft();
            _landVehicleFactory = factory.CreateTransportLandVehicle();
        }

        public void StartRoute()
        {
            _aircraftFactory.StartRoute();
            _landVehicleFactory.StartRoute();
        }
    }
}
