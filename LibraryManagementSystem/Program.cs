using ItemAlias=LibraryManagementSystem.Items;
using Microsoft.VisualBasic;
using LibraryManagementSystem.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        var book=new ItemAlias.Book{Title="A new book",Author="Avishek",ItemID=1};
        book.GetItemDetails();
        System.Console.Write($"Late fee for 3 days: ");
        book.CalculateLateFee(3);

        IReservable reservableBook=book;
        reservableBook.ReserveStatus();
        INotifiable notify=book;
        notify.Notification("Book Booked");
    }
}