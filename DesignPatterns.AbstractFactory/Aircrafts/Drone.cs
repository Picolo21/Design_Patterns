namespace DesignPatterns.AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos com velocidade baixa, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda instalada no Drone, pronta para levar ao destino!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Encomenda a caminho...");
        }
    }
}
