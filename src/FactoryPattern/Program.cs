using FactoryPattern.ConcreteProducts;
using FactoryPattern.Factory;

namespace FactoryPattern;

internal class Program
{
    static void Main(string[] args)
    {
        NotificationToolFactory notificationFactory = new();
        var notificationObject = notificationFactory.CreateNotificationTool(nameof(Email));
        notificationObject.DisplayStatus();
        Console.ReadKey();
    }
}
