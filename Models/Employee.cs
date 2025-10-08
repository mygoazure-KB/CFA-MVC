using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace CFACrud.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal Salary  { get; set; }
    }
}