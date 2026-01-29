using System.Text;

public class FlipKey
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string input=Console.ReadLine()!;
        string result=CleanseAndReverse(input);
        if (string.IsNullOrEmpty(result))
        {
            System.Console.WriteLine("Invalid string");
        }
        else
        {
            System.Console.WriteLine($"Cleansed String: {result}");
        }
    }
    public static string CleanseAndReverse(string input)
    {
        string result="";
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return result;
        }
        foreach(char c in input)
        {
            if(!char.IsWhiteSpace(c) || char.IsDigit(c) || char.IsSymbol(c))
            {
                return result;
            }
        }
        input=input.ToLower();
        string filtered="";
        foreach(char c in input)
        {
            if ((int)c % 2 != 0)
            {
                filtered+=c;
            }
        }
        char[]arr=filtered.ToCharArray();
        Array.Reverse(arr);
        result=new string(arr);
        return result;
    }
}