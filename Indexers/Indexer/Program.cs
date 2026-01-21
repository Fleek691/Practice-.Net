using System.Security.Cryptography.X509Certificates;

public class Company
{
    private List<EMployee> eMployees;
    public Company()
    {
        eMployees=new List<EMployee>()
        {
          new EMployee(){EmployeeID=1,Name="Avisehk",Gender="Male"},
          new EMployee(){EmployeeID=2,Name="Lak",Gender="Female"},
          new EMployee(){EmployeeID=3,Name="Aayush",Gender="Male"},  
          new EMployee(){EmployeeID=4,Name="Aditya",Gender="Male"}, 
          new EMployee(){EmployeeID=4,Name="Sreekanth",Gender="Male"} 
        };
    }
    /// <summary>
    /// So what happens here is using this it gets the name of the particular class "Company" and in paramater we pass employeeId so it is like Company[at employee id] and inthe constructor we get and set the value of emp id
    /// </summary>
    /// <param name="employeeID"></param>
    /// <returns></returns>
    public string this[int employeeID]//Indexer uses this keyword
    {
        get
        {
            return  eMployees.FirstOrDefault(emp=> emp.EmployeeID ==employeeID)!.Name!;
        }
        set
        {
            var employee = eMployees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
            if (employee != null)
            {
                employee.Name = value;
            }
        }
    }
    public List<string> this[string gender]
    {
        get
        {
            List<string> names = new List<string>();
            foreach (var emp in eMployees)
            {
                if (emp.Gender == gender)
                {
                    names.Add(emp.Name!);
                }
            }
            return names;
        }
        set
        {
            foreach (var emp in eMployees)
            {
                if (emp.Gender == gender)
                {
                    emp.Name = value.FirstOrDefault();
                }
            }
        }
    }

    //like mebers these can be overloaded using number and type of parameters
}
public class EMployee
{
    public int EmployeeID{get;set;}
    public string? Name{get;set;}
    public string? Gender{get;set;}

}
public class Indexer
{
    public static void Main(string[] args)
    {
        Company caomp=new Company();
        System.Console.WriteLine(caomp[3]="Mothina");
        System.Console.WriteLine(caomp[3]);
    }
}