public delegate void HelloFuncDelegate(string msg);
public class Program
{
    public static void Main(string[] args)
    {
        #region Basic Delegates
        //HelloFuncDelegate del=new HelloFuncDelegate(Hello);
        //del("Hi im using delegate");
        #endregion

        #region Medium Delegates

        //ways of assingnig value in list first\|/
        // List<Employee>employees=new List<Employee>
        // {
        //     new Employee(){Id=1,Name="Avishek",Salary=5000000,Experience=5},
        //     new Employee(){Id=2,Name="Aditya",Salary=5000000,Experience=4}
        // };
        // ////second way of assigning value 
        // /// List<Employee>employees=[
        // //     new Employee(){Id=1,Name="Avishek",Salary=5000000,Experience=5},
        // //     new Employee(){Id=1,Name="Avishek",Salary=5000000,Experience=5},
        // // ];
        // //third
        // employees.Add(new Employee(){Id=2,Name="Srekanth",Salary=5000000,Experience=6});
        // employees.Add(new Employee(){Id=4,Name="Aayush",Salary=5000000,Experience=2});
        // IsPromotable isPromotable=new IsPromotable(Employee.Promotable);
        // Employee.Promotion(employees,e=>e.Experience>=5);//lambda as it return true cal also pass the condition Promotable method
        // OfficeActivity OA=new OfficeActivity(Employee.LayOff);
        // OA(employees);
        #endregion
    
        #region Multicast Delegate
        //one way of multicast
        //void or int type
        // SampleDelegate del1,del2,del3,del4,del5;
        // del1=new SampleDelegate(Multicast.SampleMethodTwo);
        // del2=new SampleDelegate(Multicast.SampleMethodThree);
        // del3=new SampleDelegate(Multicast.SampleMethodFour);
        // del4=new SampleDelegate(Multicast.SampleMethodFive);
        // del5=del1+del2+del3+del4;
        // System.Console.WriteLine(del5());
        // System.Console.WriteLine();
        // //another way
        // SampleDelegate del6=new SampleDelegate(Multicast.SampleMethodOne);
        // del6+=Multicast.SampleMethodTwo;
        // del6+=Multicast.SampleMethodThree;
        // del6+=Multicast.SampleMethodFour;
        // del6+=Multicast.SampleMethodFive;
        // del6();
        // System.Console.WriteLine();
        // del6-=Multicast.SampleMethodOne;
        // int a=del6();//stores last invoked method value if return type is smtg else  other than void
        // System.Console.WriteLine(a);

        //Void with out 

        SampleDelegate del=new SampleDelegate(Multicast.SampleMethodFour);
        int DelegateOutParamterValue=-1;
        del(out DelegateOutParamterValue);
        System.Console.WriteLine( DelegateOutParamterValue);
        #endregion
    }

    public static void Hello(string msg)
    {
        System.Console.WriteLine(msg);
    }
}