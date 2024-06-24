using AbstractFactoryPattern.Abstract_Product;

namespace AbstractFactoryPattern.Concrete_Product;
internal class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}
