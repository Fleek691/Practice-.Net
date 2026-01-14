public delegate void OfficeActivity(List<Employee> employees);

public delegate bool IsPromotable(Employee employee);
public class Employee
{
    public int Id{get;set;}
    public string? Name{get;set;}
    public int Salary{get;set;}
    public int Experience{get;set;}

    public static bool Promotable(Employee employee)
    {
        if (employee.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    

    public static void Promotion(List<Employee> employees,IsPromotable isPromotable)
    {
        foreach(Employee emp in employees)
        {
            if (isPromotable(emp))
            {
                System.Console.WriteLine($"{emp.Name} Congratulations you are promoted");
            }
        }
    }
    public static void LayOff(List<Employee> employees)
    {
        foreach(Employee emp in employees)
        {
            if (emp.Experience <= 4)
            {
                System.Console.WriteLine($"{emp.Name} Sorry your kicked out");
            }
        }
    }
}