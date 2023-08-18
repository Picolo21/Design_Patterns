using DesignPatterns.AbstractFactory.Aircrafts;

namespace DesignPatterns.AbstractFactory.Factories
{
    public interface ITransportAircraftFactory
    {
        IAircraft CreateTransportAircraft();
    }
}
