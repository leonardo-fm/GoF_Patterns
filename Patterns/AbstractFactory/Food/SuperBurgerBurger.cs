using System;

namespace AbstractFactory.Food;

public class SuperBurgerBurger : IBurger
{
    public void Prepare()
    {
        Console.WriteLine("SuperBurger burger cooked");
    }
}
