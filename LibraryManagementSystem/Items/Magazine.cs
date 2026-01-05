using LibraryManagementSystem.Interfaces;
namespace LibraryManagementSystem.Items
{
    public class Magazine : LibraryItem, IReservable, INotifiable
    {
        public override void GetItemDetails()
        {
            Console.WriteLine($"Magazine Title {Title}, Magazine Author: {Author}, Magazine Id: {ItemID}");
        }

        public override void CalculateLateFee(int days)
        {
            Console.WriteLine($"Fee is {days*0.5}");
        }

        public void ReserveStatus()
        {
            System.Console.WriteLine("Reservation Success");
        }

        public void Notification(string message)
        {
            System.Console.WriteLine("Notification Sent");
        }
    }
}