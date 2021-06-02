using System;

namespace DependencyInversion_Correct
{
    public class Logger
    {
        // This will add a complexity when there is new requirment for log        
        public void Log(ILog log, string message)
        {
            log.LogMessage(message);
        }
    }
    public interface ILog
    {
        public void LogMessage(string Message);
    }
    public class FileLog: ILog
    {
        public virtual void LogMessage(string Message)
        {
            Console.WriteLine("Write log in file" + Message);
        }
    }
    public class EmailLog : ILog
    {
        public void LogMessage(string Message)
        {
            Console.WriteLine("Write log in file" + Message);
        }
    }
    public class PaperLog : ILog
    {
        public void LogMessage(string Message)
        {
            Console.WriteLine("Write log in paper" + Message);
        }
    }
}
