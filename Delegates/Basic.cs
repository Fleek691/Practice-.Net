public delegate int MathOperation(int a,int b);
public class Calculator
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
    public static int SUbtract(int a,int b)
    {
        return a-b;
    }
    public static int Multiply(int a,int b)
    {
        return a*b;
    }
    public static int Divide(int a,int b)
    {
        return a/b;
    }
}
public class MoreQues
{
    public static void Main()
    {
        MathOperation op;
        op=Calculator.Add;
        System.Console.WriteLine(op(3,3));
        op=Calculator.Divide;
        System.Console.WriteLine(op(6,3));
    }
}