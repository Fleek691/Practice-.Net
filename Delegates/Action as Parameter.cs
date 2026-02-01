public class Basic5
{
    public static void Main()
    {
        Process(5,Print);
        Process(5,Square);
        Process(5,PrintCube);

    }
    public static void Process(int n,Action<int> action)
    {
        action(n);
    }
    public static void Print(int a)
    {
        System.Console.WriteLine(a);
    }
    public static void PrintCube(int a)
    {
        System.Console.WriteLine(a*a*a);
    }
    public static void Square(int a)
    {
        System.Console.WriteLine(a*a);
    }
}