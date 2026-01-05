using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Items
{
    public class Book : LibraryItem, IReservable, INotifiable
    {
        public override void GetItemDetails()
        {
            Console.WriteLine($"Book Title {Title}, Book Author: {Author}, Book Id: {ItemID}");
        }

        public override void CalculateLateFee(int days)
        {
            Console.WriteLine($"Fee is {days*1}");
        }

        void IReservable.ReserveStatus()
        {
            System.Console.WriteLine("Reservation Success");
        }

        void INotifiable.Notification(string message)
        {
            System.Console.WriteLine("Notification Sent");
        }
    }
}