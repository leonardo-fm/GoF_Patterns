namespace Factory;

public abstract class Car
{
    public abstract string GetColor();
    public abstract int GetHP();

    public string GetDescription()
    {
        return $"Color: {GetColor()}, HP: {GetHP()}";
    }
}
