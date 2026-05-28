
namespace Task_Management_System.Models
{
    // A globally accessible session manager to hold the active user's identity context
    public static class UserSession
    {
        public static string CurrentStudentId { get; set; }
        public static string CurrentUserRole { get; set; } // "Admin" or "Student"
    }
}