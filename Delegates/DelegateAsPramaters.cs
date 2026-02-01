public delegate int Operation(int a);
public class Basic2
{
    public static  void Main()
    {
        int square=Porcessor(2,Square);
        int twice=Porcessor(4,Double);
        int CUbe=Porcessor(3,cube);
        System.Console.WriteLine($"{square},{twice},{CUbe}");
    }
    public static int Porcessor(int a,Operation op)
    {
        return op(a);
    }
    public static int Square(int a)
    {
        return a*a;
    }
    public static int cube(int a)
    {
        return a*a*a;
    }
    public static int Double(int a)
    {
        return a*2;
    }
}