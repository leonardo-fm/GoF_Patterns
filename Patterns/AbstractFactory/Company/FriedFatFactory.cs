using AbstractFactory.Food;

namespace AbstractFactory.Company;

public class FriedFatFactory : IFastFoodFactory
{
    public IFried GetFried()
    {
        return new FriedFatFried();
    }

    public IBurger GetBurger()
    {
        return new FriedFatBurger();
    }
}
