namespace DesignPatterns.FactoryMethod.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda recebida!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega de bike.");
        }
    }
}
