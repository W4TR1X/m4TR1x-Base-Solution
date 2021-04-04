using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Services
{
    public abstract class BaseService : IDisposable
    {
        public bool Disposed { get; private set; }

        public void Dispose()
        {
            if (!Disposed)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        public abstract void Dispose(bool disposing);
    }
}
