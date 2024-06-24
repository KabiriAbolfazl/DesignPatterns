using AbstractFactoryPattern.Abstract_Factory;

namespace AbstractFactoryPattern.Client;
internal class ShapeClient
{
    private readonly IShapeFactory shapeFactory;
    public ShapeClient(IShapeFactory shapeFactory)
    {
        this.shapeFactory = shapeFactory;
    }
    public void DrawShape() => shapeFactory.CreateShape().Draw();

}
