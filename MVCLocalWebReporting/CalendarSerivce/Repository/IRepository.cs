using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSerivce.Ropository
{
    interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllRecords();

        TEntity GetRecordByID(int id);

        void InsertRecord(TEntity record);

        void DeleteRecordById(int id);

        void UpdateRecord(int id, TEntity record);
    }
}
