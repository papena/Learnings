using System;

namespace BridgePattern
{
    //bridge components
    public interface ILogger
    {
        void LogInfo(string message);
    }
    //referecen to the bridge component
    public abstract class Logger
    {
        public  ILogger logger;
        public abstract void LogInfo(string message);
    }
    // way of logging
    public class Log : Logger
    {
        public override void LogInfo(string message)
        {
            logger.LogInfo(message);
        }
    }
    //serilog logging
    public class SerilogLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    //serilog logging
    public class WebserviceLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
