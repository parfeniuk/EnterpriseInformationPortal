using System;
using System.Collections.Generic;
using System.Text;

namespace DbSyncService
{
    public interface IDbSyncWorker
    {
        void SynchronizeTables();
    }
}
