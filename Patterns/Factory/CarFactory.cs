using System;
using Factory.Cars;

namespace Factory;

public class CarFactory
{
    public Car GetCar(CarType carType, string color, int hp)
    {
        switch (carType)
        {
            case CarType.Racing:
                return new RaceCar(color, hp);
            case CarType.City:
                return new CityCar(color, hp);
            default:
                throw new ArgumentOutOfRangeException(nameof(carType), carType, null);
        }
    }
}
