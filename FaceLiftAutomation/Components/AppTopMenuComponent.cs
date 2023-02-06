using LsportsAutomation.Infra;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Components
{
    public class AppTopMenuComponent : BaseComponent
    {
        public AppTopMenuComponent(IWebDriver Driver, WebDriverWait Wait, By by) : base(Driver, Wait)
        {
        }

        public AppTopMenuComponent TextSearchFieldAndSearch(WebDriverWait Wait, string key)
        {
            ActionBot.WaitAndSendKey(Wait, By.Id("float-input"), key);
            ActionBot.WaitAndClick(Wait, By.XPath("//i[contains(text(),'search')]"));
            return this;
        }
        public void IsLoaderDisplayed()
        {
            ActionBot.IsElementDisplayed(Wait, By.XPath("//div[@class='ng-tns-c72-1 ng-star-inserted']"));
        }

        //Just for Quarter Back :
        public AppTopMenuComponent InsertTextSearchFieldClickSearch(WebDriverWait Wait, string key)
        {
            Thread.Sleep(3000);
            ActionBot.WaitForElementClickable(Wait,By.Id("float-input"));
            ActionBot.WaitAndClick(Wait, By.Id("float-input"));
            ActionBot.WaitAndSendKey(Wait, By.Id("float-input"), key);
            Thread.Sleep(2000);
            ActionBot.WaitForElementClickable(Wait, By.XPath("//i[@class='pi pi-search']"));
            ActionBot.WaitAndClick(Wait, By.XPath("//i[@class='pi pi-search']"));
            return this;
        }


        public void IsLandingPageBreadCrumbsDisplayed(string breadCrumb)
        {
            //ActionBot.IsElementDisplayed(Wait, Driver, By.XPath("//div[contains(text(),'Trading Floor / InPlay')]"));
            //var element = Driver.FindElement(By.XPath("//div[contains(text(),'Trading Floor / InPlay')]")).GetAttribute;
            //Assert.That(element, Is.EqualTo(breadCrumb));
        }

        public AppTopMenuComponent IsLandingTopReportPageBreadCrumbsIsExsit(string breadCrumbs)
        {
            ElementBot.FindElement(Driver, By.XPath("//div[contains(text(),'Trading Floor / InPlay')]"));

            return this;
        }

        public void IsReportPageBreadCrumbsDisplayed()
        {
            ActionBot.IsElementDisplayed(Wait, By.XPath("//div[contains(text(),' Reports ')]"));

        }

        public AppTopMenuComponent IsReportTopReportPageBreadCrumbsIsExsit(string breadCrumbs)
        {
            ElementBot.FindElement(Driver, By.XPath("//div[contains(text(),' Reports ')]"));
            return this;
        }

        public AppTopMenuComponent ClikUserProfileButton()
        {
            ActionBot.WaitAndClick(Wait, By.XPath("//button[@type='text']"));
            return this;
        }



    }

}
