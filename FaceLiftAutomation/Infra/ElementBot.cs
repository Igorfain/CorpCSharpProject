using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace LsportsAutomation.Infra
{
    public class ElementBot
    {
        public static void FindElement(IWebDriver Driver,By elementBy)
        {
            Driver.FindElement(elementBy);
        }

        public static void FindElements(IWebDriver Driver, By elementBy)
        {
            Driver.FindElements(elementBy);
        }

        public static void SwitchToFrame(IWebDriver Driver, By elementBy)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(elementBy));
         
        }

        public static void SwitchToDefaultContent(IWebDriver Driver)
        {
            Driver.SwitchTo().DefaultContent();

        }

    }
}
