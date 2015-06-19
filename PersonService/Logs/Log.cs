using System.Collections.Generic;
using PersonService.Models.Context;

namespace PersonService.Logs
{
    public class Log : List<LogEvent>
    {
        public int LogId { get; set; }

        public static void WriteLog(LogEvent le)
        {
            var db = new PersonContext();

            db.Logs.Add(le);
            db.SaveChanges();
        }
    }
}