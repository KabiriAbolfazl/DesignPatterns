
using AbstractFactoryPattern.Client;
using AbstractFactoryPattern.Concrete_Factory;

ShapeClient client = new(new CircleFactory());
client.DrawShape();

ShapeClient rectangleClient = new(new RectangleFactory());
rectangleClient.DrawShape();

Console.ReadKey();