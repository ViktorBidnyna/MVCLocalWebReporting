using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calendar.Controllers
{
    public class WorkController : ApiController
    {
        // GET api/work
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/work/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/work
        public void Post([FromBody]string value)
        {
        }

        // PUT api/work/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/work/5
        public void Delete(int id)
        {
        }
    }
}
