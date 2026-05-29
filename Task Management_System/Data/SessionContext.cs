using System;

namespace Task_Management_System.Data
{
    public static class SessionContext
    {
        /// <summary>
        /// Globally shared active token tracking the selected student.
        /// Written by Admin Registration and pulled by the Student Profile control.
        /// </summary>
        public static string ActiveStudentId { get; set; } = "STU-2026-0001";
    }
}