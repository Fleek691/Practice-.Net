using System.Text;

public class FlipKey
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the word");
        string input = Console.ReadLine()!;
        string result = CleanseAndInvert(input);
        if (string.IsNullOrEmpty(result))
        {
            System.Console.WriteLine("Invalid Input");
        }
        else
        {
            System.Console.WriteLine($"The generated key is - {result}");
        }
    }
    public static string CleanseAndInvert(string input)
    {
        string result = "";

        // Validation: Not null and at least 6 characters
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return result;
        }

        // Validation: No spaces, digits, or special characters (only letters allowed)
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return result;
            }
        }

        // Convert to lowercase
        input = input.ToLower();

        // Remove characters with even ASCII values
        string filtered = "";
        foreach (char c in input)
        {
            if ((int)c % 2 != 0)  // Keep only odd ASCII values
            {
                filtered += c;
            }
        }

        // Reverse the string
        char[] arr = filtered.ToCharArray();
        Array.Reverse(arr);

        // Convert even-positioned characters (0-based) to uppercase
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                arr[i] = char.ToUpper(arr[i]);
            }
        }

        result = new string(arr);
        return result;
    }
}