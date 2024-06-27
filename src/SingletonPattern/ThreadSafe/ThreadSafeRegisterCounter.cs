namespace SingletonPattern.ThreadSafe;
internal class ThreadSafeRegisterCounter
{
    private static ThreadSafeRegisterCounter instance;
    private int totalRegisterCount = 0;
    private static readonly object lockObject = new object();
    private ThreadSafeRegisterCounter() { }

    public static ThreadSafeRegisterCounter Instance
    {
        get
        {
            if (instance is null)
            {
                lock (lockObject)
                {
                    if (instance is null)
                        instance = new ThreadSafeRegisterCounter();
                }
            }
            return instance;
        }
    }

    public int TotalRegisterCount
    {
        get
        {
            return totalRegisterCount;
        }
    }

    public void Register()
    {
        totalRegisterCount++;
        Console.WriteLine($"#{totalRegisterCount}");

    }
}
