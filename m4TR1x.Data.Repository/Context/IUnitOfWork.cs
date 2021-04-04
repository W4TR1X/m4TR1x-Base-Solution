using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Data.Repository.Context
{
    public interface IUnitOfWork : IDisposable
    {
        //Used with ef core 

        //ITableXRepository TableX { get; }
        //m4TR1xDbContext Context { get; }

        int Commit();
        void Rollback();
    }
}
