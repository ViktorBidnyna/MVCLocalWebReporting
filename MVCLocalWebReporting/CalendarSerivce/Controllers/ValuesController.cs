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
    public class ValuesController : ApiController
    {
        // GET api/values

        UnitOfWorkService _container = new UnitOfWorkService();

        public IEnumerable<Tasks> Get()
        {
            var allRecords = _container.TaskRepository.GetAllRecords();
            IEnumerable<Tasks> tasks = allRecords.Select(i => new Tasks(i.TaskName, i.Description, i.CreationDate, i.HoursForResolve));
            return tasks;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Deleted " + id;
        }
    }
}
