namespace Builder;

public class CompanyComputerDirector
{
    public IComputer BuildCompanyComputer()
    {
        ComputerBuilder computerBuilder = new ComputerBuilder();
        computerBuilder
            .Case("Old K98")
            .MotherBoard("M 234")
            .HDD("Tes 96GB")
            .PowerSupply("BZ 300W")
            .CPU("Slow 6000k");

        return computerBuilder.Build();
    }
}
