public delegate void Notify(string a);
public class Basic3
{
    public static void Main()
    {
        Notify notificate=Mrng;
        notificate+=Aft;
        notificate+=Even;
        notificate("Avishek");
    }
    public static void Mrng(string a)
    {
        System.Console.WriteLine("Good Morning"+a);
    }
    public static void Aft(string a)
    {
        System.Console.WriteLine("Good Afternonn"+a);
    }
    public static void Even(string a)
    {
        System.Console.WriteLine("Good Evening"+a);
    }
}