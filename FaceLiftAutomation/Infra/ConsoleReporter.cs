using System.Diagnostics;


namespace LsportsAutomation.Infra
{
    public class ConsoleReporter
    {
        public static void Log(string message)
        {
            Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss] ") + message + "\n");
#if DEBUG
            Debug.WriteLine(DateTime.Now.ToString("[HH:mm:ss] ") + message + "\n");
#endif
        }
    }
}
