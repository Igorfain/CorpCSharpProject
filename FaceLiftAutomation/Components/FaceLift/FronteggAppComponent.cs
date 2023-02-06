using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using LsportsAutomation.Infra;

namespace LsportsAutomation.Components.FaceLift
{
    public class FronteggAppComponent : BaseComponent
    {
        public FronteggAppComponent(IWebDriver Driver, WebDriverWait Wait, By by) : base(Driver, Wait)
        {
        }

        public FronteggAppComponent ClickLogout()
        {
            ActionBot.WaitAndClick(Wait, By.XPath("//i[contains(text(),'logout')]"));
            return this;
        }
    }
}
