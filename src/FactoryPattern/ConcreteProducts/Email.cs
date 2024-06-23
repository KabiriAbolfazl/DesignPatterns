using FactoryPattern.Products;

namespace FactoryPattern.ConcreteProducts;
internal class Email : INotificationTool
{
    public void DisplayStatus()
    {
        Console.WriteLine("Notification tool is Email");

    }
}
