using System;

namespace Task_Management_System.Models
{
    /// <summary>
    /// POCO layout reflecting student security profile properties.
    /// </summary>
    public class DbStudentProfile
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public byte[] ProfileImageBlob { get; set; }
    }
}