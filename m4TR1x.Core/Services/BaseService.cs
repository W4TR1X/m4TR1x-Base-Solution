using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Services
{
    public abstract class BaseService : IDisposable
    {
        private bool _disposed = false;

        public void Dispose()
        {
            if (!_disposed)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        public abstract void Dispose(bool disposing);
    }
}
