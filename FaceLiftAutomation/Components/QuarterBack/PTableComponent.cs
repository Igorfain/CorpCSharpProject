using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using LsportsAutomation.Infra;


namespace LsportsAutomation.Components.QuarterBack
{
    public class PTableComponent : BaseComponent
    {
        public PTableComponent(IWebDriver driver, WebDriverWait wait, By by) : base(driver, wait)
        {
        }

        public PTableComponent SelectMarketNameFilter()
        {
            //ActionBot.WaitForElementClickable(Wait, By.XPath("//p-columnfilter[1]"));
            ActionBot.WaitAndClick(Wait, By.XPath("//p-columnfilter[1]"));

            return this;
        }

        public bool GetTableHeaderElements(List<string> headerElements)
        {
            ActionBot.WaitForElementVisible(Wait, By.TagName("tr"));
            IWebElement table = Driver.FindElement(By.TagName("thead"));
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
            foreach (IWebElement row in rows)
            {
                IList<IWebElement> cells = row.FindElements(By.TagName("td"));
                foreach (IWebElement cell in cells)
                {
                    Console.WriteLine(cell.Text);
                    Assert.AreEqual(headerElements.ToString(), cell.Text);
                }

            }

            return true;
        }

        public bool GetResultsFromSearch(string ID,string marketName,string marketFamily,string betGroup )
        {
            ActionBot.WaitForElementVisible(Wait,By.XPath("//span[contains(text(),'770')]"));
            var IDResult = Driver.FindElement(By.XPath("//span[contains(text(),'770')]"));
            var marketNameResult = Driver.FindElement(By.XPath("//span[contains(text(),' Most Run Outs ')]"));
            var marketFamilyResult = Driver.FindElement(By.XPath("//span[contains(text(),'1X2 ')]"));
            var betGroupResult = Driver.FindElement(By.XPath("//span[contains(text(),'1,2,X')]"));

            Assert.That(IDResult.Text, Is.EqualTo(ID));
            Assert.That(marketNameResult.Text, Is.EqualTo(marketName));
            Assert.That(marketFamilyResult.Text, Is.EqualTo(marketFamily));
            Assert.That(betGroupResult.Text, Is.EqualTo(betGroup));
            Console.WriteLine("Results results in table are : " + "'"+IDResult.Text + ", " + marketNameResult.Text + ", " 
                              + marketFamilyResult.Text + ", " + betGroupResult.Text + "'" );

            return true;
        }


    }
}