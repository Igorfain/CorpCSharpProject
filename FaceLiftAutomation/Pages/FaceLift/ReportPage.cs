using LsportsAutomation.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace LsportsAutomation.Pages.FaceLift
{
    public class ReportPage : BasePage
    {
        public ReportPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public AppTopMenuComponent GetAppTopMenuComponent(IWebDriver Driver, WebDriverWait Wait)
        {
            return new AppTopMenuComponent(Driver, Wait, By.TagName("app-top-menu"));
        }


    }
}
