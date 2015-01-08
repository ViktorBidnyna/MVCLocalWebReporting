using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calendar.UnitOfWorkCalendar;
using Calendar.Models;

namespace Calendar.Controllers
{
    public class CalendarController : Controller
    {
        public string Index()
        {
            UnitOfWork u = new UnitOfWork();
            Tasks t = u.TaskRepository.GetRecordByID(1);
            return t.TaskName;
        }
	}
}