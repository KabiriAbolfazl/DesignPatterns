using SingletonPattern.BaseSingleton;
using SingletonPattern.RealLife;
using SingletonPattern.ThreadSafe;

Singleton ins1 = Singleton.Instance;
Singleton ins2 = Singleton.Instance;

Console.WriteLine(ins1 == ins2);

RegisterCounter registerCounter1 = RegisterCounter.Instance;
RegisterCounter registerCounter2 = RegisterCounter.Instance;
RegisterCounter registerCounter3 = RegisterCounter.Instance;

registerCounter1.Register();
registerCounter2.Register();
registerCounter3.Register();

Console.WriteLine(registerCounter1.TotalRegisterCount);

var range = Enumerable.Range(0, 10);

Parallel.ForEach(range, i =>
{
    var registerCounterInstance = ThreadSafeRegisterCounter.Instance;
    registerCounterInstance.Register();
});

Console.WriteLine(ThreadSafeRegisterCounter.Instance.TotalRegisterCount);

Console.ReadKey();