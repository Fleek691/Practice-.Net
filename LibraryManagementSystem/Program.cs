using ItemAlias=LibraryManagementSystem.Items;
using Microsoft.VisualBasic;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Items;
using LibraryManagementSystem.Analytics;
using LibraryManagementSystem.Enum;

namespace LibraryManagementSystem
{
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

            var magazine=new ItemAlias.Magazine{Title="A new magazine",Author="Prasad",ItemID=2};
            magazine.GetItemDetails();
            System.Console.Write($"Late fee for 3 days: ");
            magazine.CalculateLateFee(3);

            IReservable ireservableMagazine=magazine;
            ireservableMagazine.ReserveStatus();
            INotifiable notifiableMagazine=magazine;
            notifiableMagazine.Notification("Magazine booked.");

            List<LibraryItem> items=new List<LibraryItem>{book,magazine};
            foreach(var item in items)
            {
                item.GetItemDetails();
                System.Console.WriteLine();
            }

            IReservable reservablebook2=book;
            reservablebook2.ReserveStatus();
            INotifiable notifiableBook2=book;
            notifiableBook2.Notification("Return book on time.");

            var book2=new ItemAlias.Book();
            var magazine2=new ItemAlias.Magazine();

            LibraryAnalytics.itemsBorrowed+=5;
            LibraryAnalytics.DisplayAnalytics();

            var member=new Users.Member{Name="Avishek",Role=UserRole.Member};
            System.Console.WriteLine($"The role is: {member.Role}");
            book.Status=ItemStatus.Borrowed;
            System.Console.WriteLine($"The status of the book is {book.Status}");

            notifiableBook2.Notification(member.Role);

            var ebook=new ItemAlias.EBook{Title="C# Fundamentals",Author="John Doe",ItemID=301};
            ebook.Download();

        }
    }
}