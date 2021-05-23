using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shahpractice.Models;
using shahpractice.Models;
using shahpractice.Models;

namespace shahpractice.Controllers
{
    public class HomeController : Controller
    {
        #region index
        public ActionResult Index()

        {

            Employee emp = new Employee()
            { Id = 12, Name = "Shahzaib", Lastname = "safdar ali", dateTime = DateTime.Now.AddDays(4), Email = "ranashahzaibulhassan@gmail.com"

            , Idonline = true



            };
            return View(emp);
        }
        #endregion


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Index","_a");
        }
        [HttpPost]
        public ActionResult Contact()
        {
            if (ModelState.IsValid)
            { ViewBag.Message = "Your contact page.";
                ModelState.Clear();
                return View();
            }
           
            return View("Index","_Layout");
        }
        [Route("add")]
        public  ActionResult Addpage()
        {

            return View();
        }
    
           
        
        [Route("{id:int}")]
        public ActionResult GetStudent(int id)
        {
            var student = Stud().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        //[Route("{id}")]
        //public string get(string id)
        //{


        //    return id;
        //}
        [Route("getall")]
        public ActionResult GetStudents()
        {
            var std1 =  Stud();
            return View(std1);
        }
        [Route("address/{id}")]
        public ActionResult GetAddress(int id)
        {
            var std = Stud().Where(x => x.Id == id).Select(x => x.add);
            return View(std);
        }
      private List<Student> Stud()

        {
            return new List<Student>
            {

                new Student()
                {

                    Id=21, Email="rana@gmil.com",Lastname="safdar",Name="shah"
                    ,add=new Address()
                    {

                        Id=12,Name="shahg"

                    }
                }, new Student()
                {

                    Id=21, Email="rana@gmil.com",Lastname="safdar",Name="shah"
                    ,add=new Address()
                    {

                        Id=12,Name="shahg"

                    }
                }
                , new Student()
                {

                    Id=21, Email="rana@gmil.com",Lastname="safdar",Name="shah"
                    ,add=new Address()
                    {

                        Id=12,Name="shahg"

                    } 
                }
                    , new Student()
                {

                    Id=21, Email="rana@gmil.com",Lastname="safdar",Name="shah"
                    ,add=new Address()
                    {

                        Id=12,Name="shahg"

                    }
                }
                



            };





        }



       
    }
}