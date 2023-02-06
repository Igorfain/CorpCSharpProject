using OpenQA.Selenium;

namespace LsportsAutomation.Infra
{
    public class StaleElementHandler
    {
        public static object AvoidStaleElementException(Func<object> action)
        {
            try
            {
                object result = action();
                return result;
            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine(">>>> Caught StaleElementReferenceException; Will retry same action again");
                Thread.Sleep(1000);
                object result = action();
                return result;
            }
        }
    }
}
