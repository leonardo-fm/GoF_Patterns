using AbstractFactory.Company;
using Builder;
using Factory;
using Singleton;

namespace _PatternTest;

class Program
{
    /*
     * https://www.digitalocean.com/community/tutorials/gangs-of-four-gof-design-patterns
     * https://www.youtube.com/@geekific
     */
    
    private static void Main(string[] args)
    {
        // Builder
        Section("Builder", () =>
        {
            CompanyComputerDirector companyComputerDirector = new CompanyComputerDirector();
            Console.WriteLine("Company computer:");
            companyComputerDirector.BuildCompanyComputer().PrintComponents();
            ComputerBuilder computerBuilder = new ComputerBuilder();
            Console.WriteLine("-----------");
            Console.WriteLine("My computer");
            computerBuilder.Case("Nice 78").MotherBoard("IDK 88").SSD("Fast 2000").PowerSupply("Ok 800W").GPU("Sesam 8900").CPU("OOP 6654k");
            computerBuilder.Build().PrintComponents();
        });
        
        // Abstract Factory
        Section("Abstract Factory", () =>
        {
            SuperBurgerFactory superBurgerFactory = new SuperBurgerFactory();
            FriedFatFactory friedFatFactory = new FriedFatFactory();
            superBurgerFactory.GetFried().Cook();
            superBurgerFactory.GetBurger().Prepare();
            friedFatFactory.GetBurger().Prepare();
        });
        
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

