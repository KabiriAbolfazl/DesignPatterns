using BuilderPattern.Builders;
using BuilderPattern.Products;

namespace BuilderPattern.ConcreteBuilders;
internal class GamingComputerBuilder : IComputerBuilder
{
    private readonly Computer computer;
    public GamingComputerBuilder()
    {
        computer = new();
    }
    public void BuildCPU() => computer.SetCPU("Intel Core i9 12900H");

    public void BuildRAM() => computer.SetRAM("KingMax 32GB DDR5");

    public void BuildStorage() => computer.SetStorage("Samsung Evo 2TB SSD Nvme");

    public Computer GetComputer() => computer;

}
