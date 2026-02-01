public delegate string StringOperation(string a);
public class Basic1
{
    public static void Main()
    {
        StringOperation del;
        del=TOUperCase;
        System.Console.WriteLine(del("avishek"));
        del=Reverse;
        System.Console.WriteLine(del("Avishek"));
    }
    public static string TOUperCase(string a)
    {
        return a.ToUpper();
    }
    public static string Reverse(string a)
    {
        char[] temp=a.ToCharArray();
        Array.Reverse(temp);
        return new string(temp);
    }
}