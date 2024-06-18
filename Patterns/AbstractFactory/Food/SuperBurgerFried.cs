using System;

namespace AbstractFactory.Food;

public class SuperBurgerFried : IFried
{
    public void Cook()
    {
        Console.WriteLine("SuperBurger fried ready");
    }
}
