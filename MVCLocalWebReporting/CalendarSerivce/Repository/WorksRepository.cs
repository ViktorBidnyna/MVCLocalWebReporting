using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarSerivce.Models;

namespace CalendarSerivce.Ropository
{
    public class WorksRepository : IRepository<Works>
    {
        ServiceModel _container;

        public WorksRepository()
        {
            _container = new ServiceModel();
        }

        public WorksRepository(ServiceModel container)
        {
            this._container = container;
        }
        
        public IEnumerable<Works> GetAllRecords()
        {
            return this._container.Works;
        }

        public Works GetRecordByID(int workId)
        {
            Works result = this._container.Works.Find(workId);
            return result;
        }

        public void InsertRecord(Works work)
        {
            this._container.Works.Add(work);
        }

        public void DeleteRecordById(int workId)
        {
            Works result = this._container.Works.Find(workId);
            this._container.Works.Remove(result);
        }

        public void UpdateRecord(int id, Works work)
        {
            this._container.Works.Add(work);
        }
    }
}
