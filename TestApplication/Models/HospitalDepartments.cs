using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class HospitalDepartments
    {

        private static List<Departments> HospitalDepts;


        private HospitalDepartments()
        {
            
        }

        public static List<Departments> GetHospitalDepartments()
        {
            if (HospitalDepts == null)
            {
                HospitalDepts = new List<Departments>();
                HospitalDepts.Add(new Departments { id = 1, Name = "A & E" });
                HospitalDepts.Add(new Departments { id = 2, Name = "Intensive Care" });
                HospitalDepts.Add(new Departments { id = 3, Name = "Eye, ear, and throat specialist" });
                HospitalDepts.Add(new Departments { id = 4, Name = "The biggest department that the hospital possibly has to hold DNA and other such stuff" });
            }

            return HospitalDepts;

        }
    }
}