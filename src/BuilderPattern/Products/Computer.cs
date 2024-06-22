using System.Text;

namespace BuilderPattern.Products;
internal class Computer
{
    private string RAM { get; set; }
    private string CPU { get; set; }
    private string Storage { get; set; }
    public void SetCPU(string cpuModel) => CPU = cpuModel;
    public void SetRAM(string ramModel) => RAM = ramModel;
    public void SetStorage(string storageModel) => Storage = storageModel;
    public void DisplayInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"RAM : {RAM}");
        stringBuilder.AppendLine($"CPU : {CPU}");
        stringBuilder.AppendLine($"Storage : {Storage}");
        Console.WriteLine(stringBuilder.ToString());
    }
}
