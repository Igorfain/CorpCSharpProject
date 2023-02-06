using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace LsportsAutomation.Components
{
    public abstract class BaseComponent
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BaseComponent(IWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }
    }
}