using AbstractFactory.Food;

namespace AbstractFactory;

public interface IFastFoodFactory
{
    public IFried GetFried();
    public IBurger GetBurger();
}
