namespace SingletonPattern.BaseSingleton;
internal class Singleton
{
    private static Singleton instance;
    private Singleton() { }
    public static Singleton Instance
    {
        get
        {
            if (instance is null) instance = new Singleton();
            return instance;
        }
    }
}
