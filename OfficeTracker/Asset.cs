public abstract class Asset
{
    public int AssetId{get;set;}
    public string Name{get;set;}
    public string AssignedTo{get;set;}

    public abstract void GetDetails();
}

public class Laptop : Asset, IServicable
{
    public override void GetDetails()
    {
        System.Console.WriteLine($"Asset Id: {AssetId}, Asset Name: {Name},Assigned to: {AssignedTo}.");
    }

    public void IsServiceAble()
    {
        System.Console.WriteLine($"This item is Serviceable.");
    }
}
public class Projector : Asset, IServicable
{
    public override void GetDetails()
    {
        System.Console.WriteLine($"Asset Id: {AssetId}, Asset Name: {Name},Assigned to: {AssignedTo}.");
    }

    public void IsServiceAble()
    {
        System.Console.WriteLine($"This item is Serviceable.");
    }
}
public class Furniture : Asset, IMoveable
{
    public override void GetDetails()
    {
        System.Console.WriteLine($"Asset Id: {AssetId}, Asset Name: {Name},Assigned to: {AssignedTo}.");
    }

    public void IsMoveable()
    {
        System.Console.WriteLine($"This item is Moveable.");
    }
}