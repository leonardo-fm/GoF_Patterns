namespace Factory.Cars;

public class CityCar : Car
{
    private string color;
    private int hp;

    public CityCar(string color, int hp)
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
