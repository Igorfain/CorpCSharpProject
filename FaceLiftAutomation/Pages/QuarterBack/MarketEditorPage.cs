using LsportsAutomation.Components;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using LsportsAutomation.Components.QuarterBack;
using LsportsAutomation.Infra;
using LsportsAutomation.Components.FaceLift;

namespace LsportsAutomation.Pages.QuarterBack
{
    public class MarketEditorPage : BasePage
    {
        public MarketEditorPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void IsLoaderDisplayed()
        {
            ActionBot.IsElementDisplayed(Wait,By.XPath("//div[@class='ng-tns-c72-1 ng-star-inserted']"));
        }

        public void VerifyOnPage()
        {
            ActionBot.IsElementDisplayed(Wait, By.XPath("//div[contains(text(),' Market Editor ')]"));
        }

        public void NavigateToMarketEditorPage()
        {
            Driver.Navigate().GoToUrl("https://quarterback.dev.lsports.cloud/markets/market-editor");
            Driver.Navigate().Refresh();
            IsLoaderDisplayed();

            VerifyOnPage();
        }

        public AppTopMenuComponent GetAppTopMenuComponent()
        {
            return new AppTopMenuComponent (Driver, Wait, By.TagName("app-common-modal-layout-with-header"));
        }

        public PTableComponent GetPTableComponent()
        {
            return new PTableComponent(Driver, Wait, By.TagName("p-table"));
        }

        public PColumnFilterFormElementComponent GetPColumnFilterFormElementComponent()
        {
            return new PColumnFilterFormElementComponent(Driver, Wait, By.TagName("p-table"));
        }
    }
}