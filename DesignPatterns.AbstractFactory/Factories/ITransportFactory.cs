namespace DesignPatterns.AbstractFactory.Factories
{
    public interface ITransportFactory : ITransportAircraftFactory, ITransportLandVehicleFactory
    {
    }
}
