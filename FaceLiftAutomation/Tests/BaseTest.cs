using Allure.Net.Commons;
using Microsoft.Extensions.Configuration;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LsportsAutomation.Tests
{
    public abstract class BaseTest
    {

        public IWebDriver Driver;
        public WebDriverWait Wait;

        [SetUp]
        public void Setup()
        {
            var Config = new ConfigurationBuilder().AddJsonFile("Config.json").Build();
            var headless = Config.GetValue<string>("AppSettings:URL");

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArguments("--headless");
            Driver = new ChromeDriver(options);
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

        }

        [TearDown]
        public void CloseBrowser()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = $"{Environment.CurrentDirectory}\\allure-screenshots\\{filename}";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                TestContext.AddTestAttachment(path);
                AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
                Driver.Quit();
            }

            Driver.Quit();
        }
    }
}