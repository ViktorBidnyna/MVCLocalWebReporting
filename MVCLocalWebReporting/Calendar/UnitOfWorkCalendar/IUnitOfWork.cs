using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.UnitOfWorkCalendar
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}