namespace Singleton;

public class MySingleton
{
    private static MySingleton? instance;

    public static MySingleton GetInstance()
    {
        if (instance == null)
            instance = new MySingleton();

        return instance;
    }

    public string GetGreetings() => "Hi from singleton!";
}
