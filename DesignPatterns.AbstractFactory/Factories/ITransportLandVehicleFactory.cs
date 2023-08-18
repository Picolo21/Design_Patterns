using DesignPatterns.AbstractFactory.LandVehicles;

namespace DesignPatterns.AbstractFactory.Factories
{
    public interface ITransportLandVehicleFactory
    {
        ILandVehicle CreateTransportLandVehicle();
    }
}
