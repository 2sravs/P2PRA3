using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    public class StudentsViewModel
    {
        public double AverageMarks { get; set; }
        public int HighestMarks { get; set; }
        public int LowestMarks { get; set; }
        public int TotalStudents { get; set; }
    }
}