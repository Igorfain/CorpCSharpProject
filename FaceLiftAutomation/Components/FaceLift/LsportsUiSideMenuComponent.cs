using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using LsportsAutomation.Infra;

namespace LsportsAutomation.Components.FaceLift
{
    public class LsportsUiSideMenuComponent : BaseComponent
    {
        public LsportsUiSideMenuComponent(IWebDriver driver, WebDriverWait wait, By by) : base(driver, wait)
        {
        }

        public LsportsUiSideMenuComponent ToggleButtonExpandClose()
        {
            ActionBot.WaitForElementVisible(Wait, By.XPath("//i[contains(text(),'chevron_right')]"));
            Thread.Sleep(2000); //Temporary intercepted element solution,need to wait for Loader unvisible. Need to check Loader element
            ActionBot.WaitAndClick(Wait, By.XPath("//i[contains(text(),'chevron_right')]"));
            return this;
        }

        public LsportsUiSideMenuComponent ToggleButtonExpandExpand()
        {
            ActionBot.WaitAndClick(Wait, By.XPath("//i[contains(text(),'chevron_right')]"));
            return this;
        }


    }


}



