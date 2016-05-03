using System;
using System.Diagnostics;

namespace transfer_log {
    class Program {
        static void Main( string[] args ) {

            EventLog log_application = new EventLog();
            log_application.Log = "Application";
            foreach( EventLogEntry entry in log_application.Entries ) {
                Console.WriteLine("\tEntry: " + entry.Message);
            }  
            //http://stackoverflow.com/questions/5711586/how-to-read-application-log-and-filter-it-based-on-source-in-asp-net
        }
    }
}
