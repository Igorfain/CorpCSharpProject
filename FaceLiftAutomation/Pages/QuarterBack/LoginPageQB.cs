using LsportsAutomation.Components.QuarterBack;
using LsportsAutomation.Infra;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Pages.QuarterBack
{
    public class LoginPageQB : BasePage
    {
        public LoginPageQB(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public FormComponent GetFormComponent()
        {
            return new FormComponent(Driver, Wait, By.TagName("app-common-modal-layout-with-header"));
        }

        public void VerifyOnPage()
        {
            ActionBot.IsElementDisplayed(Wait, By.XPath("//h5[contains(text(),'Login')]"));
        }

        public LoginPageQB LoginToQarterBack(string username, string password, string pageURL)
        {
            Driver.Navigate().GoToUrl(pageURL);
            VerifyOnPage();
            GetFormComponent().UserNameInput(username);
            GetFormComponent().PasswordInput(password);
            GetFormComponent().ClickLoginButton();
            Driver.Navigate().Refresh();

            return this;
        }
    }
}