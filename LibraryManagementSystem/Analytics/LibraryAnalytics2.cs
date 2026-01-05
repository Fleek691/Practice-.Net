namespace LibraryManagementSystem.Analytics
{
    public partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
             System.Console.WriteLine($"Total items borrowed:{itemsBorrowed}");
        }
    }
}