using LsportsAutomation.Infra;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Components.QuarterBack
{
    public class FormComponent : BaseComponent
    {
        public FormComponent(IWebDriver driver, WebDriverWait wait, By by) : base(driver, wait)
        {
        }

        public FormComponent UserNameInput(string key)
        {
            ActionBot.WaitAndSendKey(Wait, By.Id("Username"), key);
            return this;
        }

        public FormComponent PasswordInput(string key)
        {
            ActionBot.WaitAndSendKey(Wait, By.Name("Password"), key);
            return this;
        }
        public FormComponent ClickLoginButton()
        {
            ActionBot.WaitAndClick(Wait, By.Name("button"));
            return this;
        }



    }
}
