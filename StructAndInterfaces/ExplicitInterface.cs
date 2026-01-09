public interface I1
{
    void GetName();
}
public interface I2
{
    void GetName();

}
public class Explicit : I1, I2
{
    void I1.GetName()
    {
        System.Console.WriteLine("I1");
    }
    void I2.GetName()
    {
        System.Console.WriteLine("I2");
    }
}
