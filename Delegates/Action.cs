
public class Basic4
{
    public static void Main()
    {
        Action<string> Notifya=GOodAfternoon;
        Notifya+=GOodEVening;
        Notifya+=GOodMorning;
        Notifya.Invoke("Avishek");
        
    }
    public static void GOodMorning(string a)
    {
        System.Console.WriteLine($"Good morning {a}");
    }
    public static void GOodAfternoon(string a)
    {
        System.Console.WriteLine($"Good Afternoon {a}");
    }
    public static void GOodEVening(string a)
    {
        System.Console.WriteLine($"Good Evening {a}");
    }
}