public class Program1
{
    public static void Main(string[] args)
    {
        int[] Va= (int[])Enum.GetValues(typeof(Gender));
        foreach(var item in Va)
        {
            System.Console.WriteLine(item);
        }
        string[] val=Enum.GetNames(typeof(Gender));
        foreach(var item in val)
        {
            System.Console.WriteLine(item);
        }
        Gender gender=(Gender)3;
        System.Console.WriteLine(gender);
        int unknow=(int)Gender.unknown;
        System.Console.WriteLine(unknow);
    }
}
public enum Gender
{
    male=1,
    female=3,
    unknown=32,
}