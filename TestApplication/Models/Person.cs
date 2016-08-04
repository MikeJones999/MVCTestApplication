using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool livesInUK { get; set; }
        public HospitalDepartments HospitalDept { get; set; }
    }
}