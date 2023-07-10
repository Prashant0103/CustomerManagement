
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BAL.Service
{
    public class BaseService : IDisposable
    {
        //protected static UnitOfWork UnitOfWork = new UnitOfWork();
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            GC.SuppressFinalize(this);
        }
    }
}
