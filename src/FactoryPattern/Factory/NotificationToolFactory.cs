using FactoryPattern.Products;

namespace FactoryPattern.Factory;
internal class NotificationToolFactory
{
    internal INotificationTool CreateNotificationTool(string concreteName)
    {
        return (INotificationTool)Activator.CreateInstance(Type.GetType($"FactoryPattern.ConcreteProducts.{concreteName}")!)!;
    }
}
