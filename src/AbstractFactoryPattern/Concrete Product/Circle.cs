using AbstractFactoryPattern.Abstract_Product;

namespace AbstractFactoryPattern.Concrete_Product;
internal class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}
