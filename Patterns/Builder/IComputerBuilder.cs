namespace Builder;

public interface IComputerBuilder
{
    public IComputerBuilder MotherBoard(string name);
    public IComputerBuilder CPU(string name);
    public IComputerBuilder GPU(string name);
    public IComputerBuilder PowerSupply(string name);
    public IComputerBuilder HDD(string name);
    public IComputerBuilder SSD(string name);
    public IComputerBuilder Case(string name);
}
