public class FuncUsage
{
    public static void Main()
    {
        Process(2,n=>n*n);
        Process(2,n=>n*n*n);
        Process(2,n=>n*2);
    }
    public static void Process(int n,Func<int,int> func)
    {
        System.Console.WriteLine(func(n));
    }
}