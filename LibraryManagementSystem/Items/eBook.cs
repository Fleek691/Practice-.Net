using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Items
{
    public class EBook : LibraryItem
    {
        public override void CalculateLateFee(int days)
        {
            System.Console.WriteLine($"Fee is {days*0.5}");
        }

        public override void GetItemDetails()
        {
            throw new NotImplementedException($"Ebook Title: {Title}, Author: {Author}, Id: {ItemID}");
        }

        public void Download()
        {
            System.Console.WriteLine("Ebook downloaded successfully");
        }
    }
}