using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZSZ.MvcWeb.Controllers
{
    public class TestController : Controller
    {
        //public IPersonService PersonService { get; set; }

        // GET: Test
        public ActionResult Index()
        {
            //bool b = PersonService.AddNew("123", "12423352");
            return View();
        }

        [HttpGet]
        public ActionResult JsonTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JsonTest(string name)
        {
            Person p = new Person { Id = 1, Name = "张三", BirthDate = DateTime.Now };
            return Json(p);
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}