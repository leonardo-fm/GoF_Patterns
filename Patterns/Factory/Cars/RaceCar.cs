namespace Factory.Cars;

public class RaceCar : Car
{
    private string color;
    private int hp;

    public RaceCar(string color, int hp)
    {
        this.color = color;
        this.hp = hp;
    }

    public override string GetColor()
    {
        return color;
    }

    public override int GetHP()
    {
        return hp;
    }
}
