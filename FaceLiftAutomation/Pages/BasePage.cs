using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace LsportsAutomation.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }
    }
}
