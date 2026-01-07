interface ICustomer
{
    
    public void GetName();

    //all possible members of an interface
    
    // int a; not allowed

    //  // 1. Constant (implicitly public static)
    // const int MaxLimit = 100;

    // // 2. Property (no instance fields allowed, only properties)
    // string Name { get; set; }

    // // 3. Read-only property
    // int Id { get; }

    // // 4. Method (abstract by default)
    // void DoWork();

    // // 5. Method with return type
    // int Calculate(int a, int b);

    // // 6. Event
    // event EventHandler WorkCompleted;

    // // 7. Indexer
    // string this[int index] { get; set; }

    // // 8. Default interface method (has implementation)
    // void Log(string message)
    // {
    //     Console.WriteLine($"[LOG] {message}");
    // }

    // // 9. Static method
    // static void StaticHelper()
    // {
    //     Console.WriteLine("Static method inside interface");
    // }

    // // 10. Static property
    // static int Version => 1;

    // // 11. Static abstract member (C# 11+, used heavily in generic math)
    // static abstract IAllPossibleMembers Create(string name);

    // // 12. Nested type inside interface
    // public class Info
    // {
    //     public string Description { get; set; }
    // }
}

interface ICustomer2 : ICustomer
{
    void GetName2();
}