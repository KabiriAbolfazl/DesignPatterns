using FactoryPattern.Products;

namespace FactoryPattern.ConcreteProducts;
internal class Sms : INotificationTool
{
    public void DisplayStatus()
    {
        Console.WriteLine("Notification tool is Sms");
    }
}
