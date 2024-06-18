using System;

namespace AbstractFactory.Food;

public class FriedFatFried : IFried
{
    public void Cook()
    {
        Console.WriteLine("FriedFat fried ready");
    }
}
