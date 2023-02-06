using LsportsAutomation.Components;
using LsportsAutomation.Components.FaceLift;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Pages.FaceLift
{
    public class Logout : BasePage
    {
        public Logout(IWebDriver Driver, WebDriverWait Wait) : base(Driver, Wait)
        {
        }

        public Logout LogoutFaceLift()
        {
            GetAppTopMenuComponent(Driver, Wait).ClikUserProfileButton();
            GetFronteggAppComponent(Driver, Wait).ClickLogout();
            return this;
        }

        public AppTopMenuComponent GetAppTopMenuComponent(IWebDriver Driver, WebDriverWait Wait)
        {
            return new AppTopMenuComponent(Driver, Wait, By.TagName("app-top-menu"));
        }

        public FronteggAppComponent GetFronteggAppComponent(IWebDriver Driver, WebDriverWait Wait)
        {
            return new FronteggAppComponent(Driver, Wait, By.TagName("frontegg-app"));
        }




    }
}
