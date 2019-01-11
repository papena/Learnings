using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution Started");
            Logger log = new Log();
            log.logger = new SerilogLogger();
            log.LogInfo("This is Serilog logging");
            log.logger.LogError("test");

            log.logger = new WebserviceLogger();
            log.LogInfo("This is webservice logging");
        }
    }
}
