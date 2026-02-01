public delegate string Notify(string a);
public class Basic3
{
    public static void Main()
    {
        Notify notificate=Mrng;
        notificate+=Aft;
        notificate+=Even;
        System.Console.WriteLine(notificate("Avishek"));
    }
    public static string Mrng(string a)
    {
        return "Good Morning"+a;
    }
    public static string Aft(string a)
    {
        return "Good Afternoon"+a;
    }
    public static string Even(string a)
    {
        return "Good Evening"+" "+a;
    }
}