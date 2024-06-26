namespace PrototypePattern;
internal class ComplexObject : ICloneable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ComplexObject(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public object Clone() => new ComplexObject(Id, Name);

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
    }
}
