using AbstractFactoryPattern.Abstract_Factory;
using AbstractFactoryPattern.Abstract_Product;
using AbstractFactoryPattern.Concrete_Product;

namespace AbstractFactoryPattern.Concrete_Factory;
internal class CircleFactory : IShapeFactory
{
    public IShape CreateShape() => new Circle();

}
