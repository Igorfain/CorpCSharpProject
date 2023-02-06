using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace LsportsAutomation.Infra
{
    public class ActionBot
    {
        public static void WaitUntilElementUnvisible(WebDriverWait Wait, By elementBy)
        {
            Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(elementBy));
        }

        public static void WaitForElementVisible(WebDriverWait Wait, By elementBy)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(elementBy));
        }
        public static void WaitForElementClickable(WebDriverWait Wait, By elementBy)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(elementBy));
        }

        public static void WaitAndClick(WebDriverWait Wait, By elementBy)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(elementBy)).Click();
        }

        public static void WaitAndSendKey(WebDriverWait Wait, By elementBy,String key)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(elementBy)).SendKeys(key);
        }

        public static void WaitAnPressEnter(WebDriverWait Wait, By elementBy)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(elementBy)).SendKeys(Keys.Enter);
        }

        public static void IsElementDisplayed(WebDriverWait Wait ,By elementBy)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(elementBy));

        }


    }
}

