using System;
using System.Collections.Generic;

using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class UserController : Controller
    {

       private List<Person> persons = new List<Person>();       

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [Route("User/ShowAllUsers")]
        public ActionResult ShowAllUsers()
        {
            populateUserList();
            var users = GetAllUsers();
            return View(users); 
        }

        [Route("User/ShowUserDetail/{id}")]
        public ActionResult ShowUserDetail(int id)
        {
            populateUserList();
            var user = GetUserFromList(id);
            return View(user);
        }


        private List<Person> GetAllUsers()
        {
            return persons;
        }

        Person GetUserFromList( int id)
        {
            Person temp = persons.Find(n => n.Id == id);
            return temp;
        }

      
        void populateUserList()
        {
            persons.Add(new Person { Id = 1, Name = "John", Address = "1234 high street", Age = 35 });
            persons.Add(new Person { Id = 2, Name = "paul", Address = "999 station street", Age = 77 });
        }


        public ActionResult New()
        {
            var hospitalDepts = HospitalDepartments.GetHospitalDepartments();
            var personAndHospModel = new PersonAndHospView
            {
                HospitalDepartments = hospitalDepts
            };
            return View(personAndHospModel);
        }


    }
}



//new { @class = "btn btn-info", @id = item.Id }) 