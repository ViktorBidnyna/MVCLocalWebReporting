using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalendarSerivce.UnitOfWork;
using CalendarSerivce.Models;

namespace CalendarSerivce.Controllers
{
    public class WorksController : ApiController
    {
        UnitOfWorkService _container = new UnitOfWorkService();

        public IEnumerable<Works> GetAllTasks()
        {
            return _container.WorkRepository.GetAllRecords();
        }

        // GET api/tasks/5
        public Works GetTaskById(int id)
        {
            return _container.WorkRepository.GetRecordByID(id);
        }

        // POST api/tasks
        [HttpPost]
        public IEnumerable<Works> GetAllRecords()
        {
            return _container.WorkRepository.GetAllRecords();
        }

        // PUT api/tasks/5
        public void UpdateRecord(int id, Works value)
        {
            _container.WorkRepository.UpdateRecord(id, value);
            _container.Save();
        }

        // DELETE api/tasks/5
        public void DeleteRecordById(int id)
        {
            _container.TaskRepository.DeleteRecordById(id);
            _container.Save();
        }
    }
}

