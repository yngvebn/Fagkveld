using System.Collections.Generic;
using System.Web.Mvc;

namespace ContinousDeploymentWithEF.Controllers
{
    public class HomeController: Controller // BootstrapBaseController
    {
        public ActionResult Index()
        {
            List<TestModel> list = new List<TestModel>()
                {
                    new TestModel() {Age = 23, Name = "Someone"},
                    new TestModel() {Age = 30, Name = "Else"}
                };
            return View(list);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();

        }

        public ActionResult Create()
        {
            return View();

        }
        public ActionResult Details()
        {
            return View();

        }

        public ActionResult Delete()
        {
            return View();

        }



    }

    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}