using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string picture { get; set; }
        public string Student_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Section { get; set; }
        public int Date { get; set; }
    }
}