using Factory;

namespace Singleton;

class Program
{
    private static void Main(string[] args)
    {
        // Factory
        Section("Factory", () =>
        {
            CarFactory factory = new CarFactory();
            Console.WriteLine($"Race car: {factory.GetCar(CarType.Racing, "red", 400).GetDescription()}," +
                              $"\nCity car: {factory.GetCar(CarType.City, "white", 80).GetDescription()}");
        });
        
        // Singleton
        Section("Singleton", () =>
        {
            Console.WriteLine(MySingleton.GetInstance().GetGreetings());
        });
    }

    private static void Section(string sectionName, Action action)
    {
        Console.WriteLine("*** Starting " + sectionName + " ***");
        action.Invoke();
        Console.WriteLine("*** Finished " + sectionName + " ***\n");
    }
}
