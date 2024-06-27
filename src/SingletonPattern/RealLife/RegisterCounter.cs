namespace SingletonPattern.RealLife;
internal class RegisterCounter
{
    private static RegisterCounter instance;
    private int totalRegisterCount = 0;
    private RegisterCounter() { }

    public static RegisterCounter Instance
    {
        get
        {
            if (instance is null)
                instance = new RegisterCounter();
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
