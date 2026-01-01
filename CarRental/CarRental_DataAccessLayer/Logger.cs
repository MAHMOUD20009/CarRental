using System;
using System.Diagnostics;

namespace CarRental_DataAccessLayer
{
    public static class clsLogger
    {
        private static string SourceName = "CarRental_System";

        public static void Log(string Message)
        {
            if (!EventLog.SourceExists(SourceName))
                EventLog.CreateEventSource(SourceName, "Application");

            try
            {
                EventLog.WriteEntry(SourceName, Message, EventLogEntryType.Error);
            }
            catch(Exception)
            {
            }
        }
    }
}
