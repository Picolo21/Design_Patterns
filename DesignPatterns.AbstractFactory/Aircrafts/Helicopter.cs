namespace DesignPatterns.AbstractFactory.Aircrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, vento Sudeste, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros OK. Ligando as hélices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!!!");
        }
    }
}
