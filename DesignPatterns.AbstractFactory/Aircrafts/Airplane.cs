namespace DesignPatterns.AbstractFactory.Aircrafts
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos à 25 km/h, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, voô autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
