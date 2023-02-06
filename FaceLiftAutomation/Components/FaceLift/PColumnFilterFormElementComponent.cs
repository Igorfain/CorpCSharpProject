using LsportsAutomation.Infra;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Components.FaceLift
{
    public class PColumnFilterFormElementComponent : BaseComponent
    {
        public PColumnFilterFormElementComponent(IWebDriver driver, WebDriverWait wait,By by) : base(driver, wait)
        {
        }

        public PColumnFilterFormElementComponent Select1x2MarketAndClickSave()
        {
            ActionBot.WaitAndClick(Wait, By.XPath("//label[contains(text(),'1X2')]"));
            ActionBot.WaitAndClick(Wait, By.XPath("//button[contains(text(),'Save')]"));

            return this;
        }

    }
}
