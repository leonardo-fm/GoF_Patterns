namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MySingleton.GetInstance().GetGreetings());
    }
}
