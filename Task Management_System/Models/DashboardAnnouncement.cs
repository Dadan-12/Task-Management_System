using System;

namespace Task_Management_System.Models
{
    public class DashboardAnnouncement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string DatePosted { get; set; }
        public int Priority { get; set; }
    }
}