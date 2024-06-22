using BuilderPattern.Products;

namespace BuilderPattern.Builders;
internal interface IComputerBuilder
{
    void BuildRAM();
    void BuildCPU();
    void BuildStorage();
    Computer GetComputer();
}
