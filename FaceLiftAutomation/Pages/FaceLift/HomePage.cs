using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LsportsAutomation.Components;

namespace LsportsAutomation.Pages.FaceLift
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public AppTopMenuComponent GetAppTopMenuComponent(IWebDriver Driver, WebDriverWait Wait)
        {
            return new AppTopMenuComponent(Driver, Wait, By.TagName("app-top-menu"));
        }


    }
}
