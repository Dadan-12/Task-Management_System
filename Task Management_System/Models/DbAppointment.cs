using System;

namespace Task_Management_System.Models
{
    public class DbAppointment
    {
        public string UniqueId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int LabelKey { get; set; }
        public int StatusKey { get; set; }
        public bool AllDay { get; set; }
        public string Location { get; set; }
        public string ReminderInfo { get; set; }
    }
}