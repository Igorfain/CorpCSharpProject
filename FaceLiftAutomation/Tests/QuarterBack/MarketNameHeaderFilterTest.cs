using LsportsAutomation.Infra;
using LsportsAutomation.Pages.QuarterBack;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace LsportsAutomation.Tests.QuarterBack
{
    [AllureNUnit]
    [TestFixture]
    public class MarketNameHeaderFilterTest : BaseTest
    {

        [Test]
        [AllureName("Validate Header Filter ")]
        [AllureTag("Quarter Back")]
        [Category("Markets")]

        public void ValidateHeaderMarketNameFilter()
        {
 
            AppConfiguration appConfiguration = new AppConfiguration();
            appConfiguration.ReadConfigFile(out string URL, out string user,out string pass );

            ConsoleReporter.Log("Step - 1 Login to Quarter Back");
            LoginPageQB loginPageQB = new LoginPageQB(Driver, Wait);
            loginPageQB.LoginToQarterBack(user, pass, URL);
           
            ConsoleReporter.Log("Step - 2 Navigate to Market Editor page");
            MarketEditorPage marketEditorPage = new MarketEditorPage(Driver, Wait);
            marketEditorPage.NavigateToMarketEditorPage();

            ConsoleReporter.Log("Step - 3 Click the filter button");
            marketEditorPage.GetPTableComponent().SelectMarketNameFilter();

            ConsoleReporter.Log("Step - 4 Select 1X2 market checkbox and Save");
            marketEditorPage.GetPColumnFilterFormElementComponent().Select1x2MarketAndClickSave();


             //Thread.Sleep(3000);
        }

    }
}
