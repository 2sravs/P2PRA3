using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal Marks { get; set; }
    }
}