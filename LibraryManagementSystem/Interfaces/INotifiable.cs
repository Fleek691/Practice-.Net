using LibraryManagementSystem.Enum;

namespace LibraryManagementSystem.Interfaces
{
    public interface INotifiable
    {
        public void Notification(string message);
        public void Notification(UserRole role);
    }
}