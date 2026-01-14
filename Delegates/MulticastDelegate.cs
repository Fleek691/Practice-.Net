public delegate void SampleDelegate(out int Number);//first void then int and then void with out
public static class Multicast
{
    public static void SampleMethodOne(out int Number)
    {
        Number=1;
    }
    public static void SampleMethodTwo(out int Number)
    {
        Number=2;
    }
    public static void SampleMethodThree(out int Number)
    {
        Number=3;
    }
    public static void SampleMethodFour(out int Number)
    {
        Number= 4;
    }
    public static void SampleMethodFive(out int Number)
    {
        Number=5;
    }
}