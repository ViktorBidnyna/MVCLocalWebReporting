using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar.Models;

namespace Calendar.Ropository
{
    public class TasksRepository : IRepository<Tasks>
    {
        CalendarModelContainer _container;

        public TasksRepository()
        {
            _container = new CalendarModelContainer();
        }

        public TasksRepository(CalendarModelContainer container) 
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

        public void UpdateRecord(Tasks task)
        {
            this._container.Tasks.Add(task);
        }
    }
}