namespace DesignPatterns.AbstractFactory.LandVehicles
{
    public class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda recebida pelo entregador, já está em trânsito!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Encomenda a caminho...");
        }
    }
}
