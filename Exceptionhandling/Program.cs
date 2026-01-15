public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            for(int i = 0; i < 10; i++)
            {
            System.Console.WriteLine(10/i);
            }
        }
        catch(DivideByZeroException ex)
        {
            System.Console.WriteLine("Sorry");
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally{
            System.Console.WriteLine("Exception handled");
        }
    }
}