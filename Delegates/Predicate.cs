public class PredicateUSgae
{
    public static void Main()
    {
        CheckNumber(5,x=>x%2==0);
        CheckNumber(5,x=>x>0);
        CheckNumber(5,x=>x>10);
    }
    public static void CheckNumber(int a,Predicate<int> predicate)
    {
        if (predicate(a))
        {
            System.Console.WriteLine("Valid");
        }
        else{
           System.Console.WriteLine("InValid");
    }
    }
}