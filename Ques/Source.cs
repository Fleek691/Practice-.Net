// public class Source
// {
//     public int Add(int a,int b,int c)
//     {
//         System.Console.WriteLine("Integer");
//         return a+b+c;
//     }

//     public double Add(double a,double b,double c)
//     {
//         System.Console.WriteLine("Double");
//         return a+b+c;
//     }
// }


public class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
}


public class Pract
{
    public static void Main(string[] args)
    {
        Employee em1=new Employee{Id=1,Name="Avsihek"};
        Employee em2=new Employee{Id=2,Name="Aditya"};
        Employee em3=new Employee{Id=3,Name="Aayush"};
        Employee em4=new Employee{Id=4,Name="Sreekanth"};
        
        
    }

    
}