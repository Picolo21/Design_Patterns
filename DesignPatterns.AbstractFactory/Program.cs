using DesignPatterns.AbstractFactory.App;
using DesignPatterns.AbstractFactory.Factories;

public class Program
{
    static Application ConfigureApplication(string company)
    {
        Application app;
        ITransportFactory transportFactory;

        if (company.Equals("UBER"))
            transportFactory = new UberTransport();
        else if (company.Equals("99"))
            transportFactory = new NineNineTransport();
        else
            transportFactory = new LimeTransport();

        app = new Application(transportFactory);

        return app; 
    }

    private static void Main(string[] args)
    {
        Console.Write("Informe o nome da companhia que deseja contratar: ");
        string company = Console.ReadLine().ToUpper();
        Console.Clear();

        Application app = ConfigureApplication(company);

        app.StartRoute();

        Console.ReadKey();
    }
}