using System;

namespace DependencyInversion_Incorrect1
{
    public class Logger
    {
        // This will add a complexity when there is new requirment for log        
        public void Log(string logType, string Message)
        {
            if (logType == "File") {
                //Write code to write in file
                Console.WriteLine("Write log in file"+ Message);
            }
            if (logType == "Email")
            {
                //Write code to send log in email
                Console.WriteLine("Send log in email"+ Message);
            }
            if (logType == "Paper")
            {
                //Write code to send log on paper
                Console.WriteLine("Send log in paper"+ Message);
            }
        }
    }
}
