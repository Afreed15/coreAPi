using System;
using System.Collections.Generic;

namespace APIDbFirstStu.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Sname { get; set; }
        public int Sage { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
