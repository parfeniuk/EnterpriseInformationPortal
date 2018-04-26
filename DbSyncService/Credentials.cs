using System;
using System.Collections.Generic;
using System.Text;

namespace DbSyncService
{
    public class Credentials
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int PointNumber { get; set; }
        public string GroupName { get; set; }
    }
}
