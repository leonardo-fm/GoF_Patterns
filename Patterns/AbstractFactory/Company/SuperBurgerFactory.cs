using AbstractFactory.Food;

namespace AbstractFactory.Company;

public class SuperBurgerFactory : IFastFoodFactory
{
    public IFried GetFried()
    {
        return new SuperBurgerFried();
    }

    public IBurger GetBurger()
    {
        return new SuperBurgerBurger();
    }
}
