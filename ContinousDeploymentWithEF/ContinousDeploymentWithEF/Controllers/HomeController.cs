using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContinousDeploymentWithEF.Database;

namespace ContinousDeploymentWithEF.Controllers
{
    public class HomeController: Controller // BootstrapBaseController
    {
        public ActionResult Index()
        {
            var list = new List<Person>();
            using (Db db = new Db())
            {
                list = db.Set<Person>().ToList();
            }
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