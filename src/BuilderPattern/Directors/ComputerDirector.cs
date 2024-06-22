using BuilderPattern.Builders;

namespace BuilderPattern.Directors;
internal class ComputerDirector
{
    public void Build(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }
}
