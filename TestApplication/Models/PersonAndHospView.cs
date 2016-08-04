using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class PersonAndHospView
    {
        public List<Departments> HospitalDepartments { get; set; }
        public Person Person { get; set; }
        public String currentlySelected = "Eye, ear, and throat specialist";
    }
}