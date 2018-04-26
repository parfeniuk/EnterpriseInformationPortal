using ServiceBrokerListener.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBChangesListener
{
    public class DbListener
    {
        public void Listen()
        {
            string cmd = "select name_point from point where post=0;";
            // See constructor optional parameters to configure it according to your needs
            SqlDependencyEx listener =
                    new SqlDependencyEx
                    ("Server=sql-001.base2base.com.ua,14332;Database=b2b-test;User Id=base2base-test-user;Password=bW3GtOUQ02o0;",
                    "b2b-test", "point");


            // e.Data contains actual changed data in the XML format
            listener.TableChanged += (o, e) => Console.WriteLine("Your table was changed!");

            // After you call the Start method you will receive table notifications with 
            // the actual changed data in the XML format
            listener.Start();

            // ... Your code is here 

            // Don't forget to stop the listener somewhere!
            listener.Stop();
        }
    }
}
