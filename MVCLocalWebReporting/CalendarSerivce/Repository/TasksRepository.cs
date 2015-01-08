using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarSerivce.Models;

namespace CalendarSerivce.Ropository
{
    public class TasksRepository : IRepository<Tasks>
    {
        ServiceModel _container;

        public TasksRepository()
        {
            _container = new ServiceModel();
        }

        public TasksRepository(ServiceModel container) 
        {
            this._container = container;
        }

        public IEnumerable<Tasks> GetAllRecords()
        {
            return this._container.Tasks;
        }

        public Tasks GetRecordByID(int taskId)
        {
            Tasks result = this._container.Tasks.Find(taskId);
            return result;
        }

        public void InsertRecord(Tasks task)
        {
            this._container.Tasks.Add(task);
        }

        public void DeleteRecordById(int taskId)
        {
            Tasks result = this._container.Tasks.Find(taskId);
        }

        public void UpdateRecord(int id, Tasks task)
        {
            var taskForUpdate = (from t in _container.Tasks where t.Id == id select t).ToList();
            taskForUpdate[0] = task;
            _container.Tasks.Add(taskForUpdate[0]);
        }
    }
}