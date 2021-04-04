using System;

namespace m4TR1x.Data.Repository.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _isDisposed = false;

        //public ITableXRepository ActionRoles => _tableXRepository ??= new TableXRepository(Context);
        //private ITableXRepository _tableXRepository;

        //public m4TR1xDbContext Context { get; }

        //public UnitOfWork(m4TR1xDbContext context)
        //{
        //    Context = context;
        //}

        public int Commit()
        {
            //var result = Context.SaveChanges();
            return 0; // result;
        }
        public void Rollback()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    //Dispose all
                    //_tableXRepository?.Dispose();

                    //Context?.Dispose();
                }

                _isDisposed = true;
            }
        }
    }
}
