using LsportsAutomation.Components.FaceLift;
using LsportsAutomation.Infra;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Pages.FaceLift
{
    public class LoginPageFaceLift : BasePage
    {
        public LoginPageFaceLift(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public LoginPageFaceLift LoginFaceLift(string pageURL, string userEmail, string password)
        {
            Driver.Navigate().GoToUrl(pageURL);
            ActionBot.WaitForElementVisible(Wait, By.Name("email"));
            ActionBot.WaitAndSendKey(Wait, By.Name("email"), userEmail);
            ActionBot.WaitAnPressEnter(Wait, By.Name("email"));
            ActionBot.WaitForElementVisible(Wait, By.Name("password"));
            ActionBot.WaitAndSendKey(Wait, By.Name("password"), password);
            ActionBot.WaitAnPressEnter(Wait, By.Name("password"));
            ActionBot.WaitForElementVisible(Wait, By.XPath("//div[contains(text(),'Trading Floor / InPlay')]"));

            return this;
        }

        public LoginPageFaceLift NavigateToReportsPage()
        {
            string reportsPageURL = "https://stm.qa.lsports.cloud/pages/reports";
            IWebElement element = Driver.FindElement(By.XPath("//lsports-ui-side-menu"));
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();
            ActionBot.WaitAndClick(Wait, By.XPath("//*[contains(text(),'Reports')][1]"));
            return this;
        }

        public LsportsUiSideMenuComponent GetLsportsUiSideMenuComponent()
        {
            return new LsportsUiSideMenuComponent(Driver, Wait, By.TagName("app-common-modal-layout-with-header"));
        }



    }
}
