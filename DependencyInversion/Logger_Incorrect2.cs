using System;

namespace DependencyInversion_Incorrect2
{
    public class Logger
    {
        // This will add a complexity when there is new requirment for log        
        public void Log(string logType, string Message)
        {
            Log obj = null;
            if (logType == "File")
            {
                obj = new Log();
            }
            if (logType == "Email")
            {
                obj = new EmailLog();
            }
            if (logType == "Paper")
            {
                obj = new PaperLog();
            }
            obj.LogMessage(Message);
        }
    }
    public class Log
    {
        public virtual void LogMessage(string Message)
        {
            Console.WriteLine("Write log in file" + Message);
        }
    }
    public class EmailLog : Log
    {
        public override void LogMessage(string Message)
        {
            Console.WriteLine("Write log in file" + Message);
        }
    }
    public class PaperLog : Log
    {
        public override void LogMessage(string Message)
        {
            Console.WriteLine("Write log in paper" + Message);
        }
    }
}
