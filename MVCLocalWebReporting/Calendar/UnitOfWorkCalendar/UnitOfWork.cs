using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Calendar.Models;
using Calendar.Ropository;

namespace Calendar.UnitOfWorkCalendar
{
    public class UnitOfWork : IUnitOfWork
    {
        private CalendarModelContainer _context = new CalendarModelContainer();
        private TasksRepository _taskRepository;
        private WorksRepository _workRepository;

        public TasksRepository TaskRepository
        {
            get
            {
                if (this._taskRepository == null)
                {
                    this._taskRepository = new TasksRepository(_context);
                }
                return _taskRepository;
            }
        }

        public WorksRepository WorkRepository
        {
            get
            {
                if (this._workRepository == null)
                {
                    this._workRepository = new WorksRepository(_context);
                }
                return _workRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}