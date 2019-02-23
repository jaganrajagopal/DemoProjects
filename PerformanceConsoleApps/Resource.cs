using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceConsoleApps
{
    class Resource : IDisposable
    {
        private bool disposed = false;
       public byte [] mybyte  { get; set; }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // can clean up other managed objects  
                }
                // clean up unmanaged resources  
                disposed = true;
            }
        }
        ~Resource()
        {
            Dispose(false);
        }
    }
}
