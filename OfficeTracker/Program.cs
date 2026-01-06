public class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop= new Laptop(){AssetId=1,Name="Laptop",AssignedTo="Avishek"};
        Projector projector= new Projector(){AssetId=2,Name="Projector",AssignedTo="Aditya"};
        Furniture furniture=new Furniture(){AssetId=3,Name="Furniture",AssignedTo="Aayush"};

        laptop.GetDetails();
        laptop.IsServiceAble();
        projector.GetDetails();
        projector.IsServiceAble();
        furniture.GetDetails();
        furniture.IsMoveable();
    }
}