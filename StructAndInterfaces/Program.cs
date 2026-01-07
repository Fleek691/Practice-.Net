public class Program
{
    public static void Main(string[] args)
    {
        #region Struct Example
        // Customer C1=new Customer(1,"Avishek");
        // C1.PrintDetails();

        // Customer C2=new Customer();
        // C2.Id=2;
        // C2.Name="Aayush";
        // C2.PrintDetails();
        
        // Customer C3=new Customer//object Initializer Syntax
        // {
        //   Id=3,
        //   Name="Aditya"  
        // };
        // C3.PrintDetails();
        #endregion

        #region Value vs Ref                                 
        // int i=10;                                            //|     |
        // int j=i;                                      //-->    |i=10 |
        // j=j+1;                                               //|j=11 |
        // System.Console.WriteLine("i = {0} and j= {1}",i,j);  //|Stack|
        // //modification on j will not affect i as both are of value type and while doing j=i j is getting the copy of i
        // //
        // //c1-  |        |
        // //   -_|  Id=1  |
        // //   - |Name=avi|
        // //c2-  |  Heap  |
        // //
        // //
        // Customer c1=new Customer(
        // 1,
        // "avi"
        // );
        
        // Customer c2=c1;
        // c2.Name="Lak";
        // System.Console.WriteLine($"c1 name ={c1.Name},c2 name= {c2.Name}");//here Cutomer is struct so output "avi"
        // //after chaing the struct to class output "c1 name =Lak,c2 name= Lak"
        // Customer c3=new Customer();
        
        #endregion
    
        #region Interface
        Customer c1=new Customer();
        c1.GetName();
        #endregion
    }
}