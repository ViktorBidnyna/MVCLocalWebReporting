using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalendarSerivce.UnitOfWork;

namespace CalendarSerivce.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWorkService unit = new UnitOfWorkService();

        public ActionResult Index()
        {
            return View();
        }
    }
}
