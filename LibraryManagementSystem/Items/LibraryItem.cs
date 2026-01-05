using LibraryManagementSystem.Enum;

namespace LibraryManagementSystem.Items
{
    public abstract class LibraryItem{
        public string  Title{get;set;}
        public string Author{get;set;}
        public int ItemID{get;set;}
        public abstract void GetItemDetails();
        public abstract void CalculateLateFee(int days);
        public ItemStatus Status{get;set;}
    }
}