using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarSerivce.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}