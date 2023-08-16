using DesignPatterns.FactoryMethod.Factories;

internal class Program
{
    private static void Main(string[] args)
    {
        Transport transport = null;

        Console.WriteLine("Tipos de transportes:\n");
        Console.WriteLine("[1] - Uber");
        Console.WriteLine("[2] - Uber Eats");
        Console.WriteLine("[3] - Uber Eats de Bike");
        Console.WriteLine("[4] - Finalizar o Programa\n");
        Console.Write("Escolha o tipo de transporte que deseja utilizar: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
            transport = new CarTransport();
        else if (choice == 2)
            transport = new MotorcycleTransport();
        else if (choice == 3)
            transport = new BicycleTransport();
        else if (choice == 4)
        {
            Console.Clear();
            Console.WriteLine("Finalizando o Programa...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Programa Finalizado!");
        }
        else
            Console.WriteLine("Selecione o tipo do serviço");

        if (transport != null)
        {
            Console.Clear();
            transport.StartTransport();
        }
    }
}