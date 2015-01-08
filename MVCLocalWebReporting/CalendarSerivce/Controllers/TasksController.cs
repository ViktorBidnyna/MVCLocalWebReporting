using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalendarSerivce.UnitOfWork;
using CalendarSerivce.Models;

namespace CalendarSerivce.Controllers
{
    [EnableCors(origins: "http://localhost:65306/", headers: "*", methods: "*")]
    public class TasksController : ApiController
    {

        UnitOfWorkService _container = new UnitOfWorkService();

        public IEnumerable<Tasks> Get()
        {
            return _container.TaskRepository.GetAllRecords();
        }

        // GET api/tasks/5
        public Tasks GetTaskById(int id)
        {
            return _container.TaskRepository.GetRecordByID(id);
        }

        // POST api/tasks
        [HttpPost]
        public IEnumerable<Tasks> GetAllRecords()
        {
            return _container.TaskRepository.GetAllRecords();
        }

        // PUT api/tasks/5
        public void UpdateRecord(int id, Tasks value)
        {
            _container.TaskRepository.UpdateRecord(id, value);
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
