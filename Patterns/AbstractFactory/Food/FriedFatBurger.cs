using System;

namespace AbstractFactory.Food;

public class FriedFatBurger : IBurger
{
    public void Prepare()
    {
        Console.WriteLine("FriedFat burger cooked");
    }
}
