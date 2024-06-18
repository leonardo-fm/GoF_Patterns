using System.Text;

namespace Builder;

public class ComputerBuilder : IComputerBuilder
{
    private string motherBoardName;
    private string CPUName;
    private string GPUName;
    private string powerSupplyName;
    private string HDDName;
    private string SSDName;
    private string caseName;
   
    public IComputerBuilder MotherBoard(string name) {
        motherBoardName = name;
        return this;
    }
    
    public IComputerBuilder CPU(string name) {
        CPUName = name;
        return this;
    }
    
    public IComputerBuilder GPU(string name) {
        GPUName = name;
        return this;
    }
    
    public IComputerBuilder PowerSupply(string name) {
        powerSupplyName = name;
        return this;
    }
    
    public IComputerBuilder HDD(string name) {
        HDDName = name;
        return this;
    }
    
    public IComputerBuilder SSD(string name) {
        SSDName = name;
        return this;
    }
    
    public IComputerBuilder Case(string name) {
        caseName = name;
        return this;
    }

    public IComputer Build()
    {
        return new Computer(motherBoardName, CPUName, GPUName, powerSupplyName, HDDName, SSDName, caseName);
    }
    
    internal class Computer : IComputer
    {
        private readonly string motherBoardName;
        private readonly string CPUName;
        private readonly string GPUName;
        private readonly string powerSupplyName;
        private readonly string HDDName;
        private readonly string SSDName;
        private readonly string caseName;

        internal Computer(string motherBoardName, string cpuName, string gpuName, string powerSupplyName, string hddName, string ssdName, string caseName)
        {
            this.motherBoardName = motherBoardName;
            CPUName = cpuName;
            GPUName = gpuName;
            this.powerSupplyName = powerSupplyName;
            HDDName = hddName;
            SSDName = ssdName;
            this.caseName = caseName;
        }

        public void PrintComponents()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(motherBoardName))
                sb.Append("Mother board: " + motherBoardName + "\n");
            if (!string.IsNullOrWhiteSpace(CPUName))
                sb.Append("CPU: " + CPUName + "\n");
            if (!string.IsNullOrWhiteSpace(GPUName))
                sb.Append("GPU: " + GPUName + "\n");
            if (!string.IsNullOrWhiteSpace(powerSupplyName))
                sb.Append("Power supply: " + powerSupplyName + "\n");
            if (!string.IsNullOrWhiteSpace(HDDName))
                sb.Append("HDD: " + HDDName + "\n");
            if (!string.IsNullOrWhiteSpace(SSDName))
                sb.Append("SSD: " + SSDName + "\n");
            if (!string.IsNullOrWhiteSpace(caseName))
                sb.Append("Case: " + caseName + "\n");
            
            Console.Write(sb.ToString());
        }
    }
}
