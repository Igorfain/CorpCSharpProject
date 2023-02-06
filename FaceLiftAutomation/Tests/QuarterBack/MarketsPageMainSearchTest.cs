using LsportsAutomation.Infra;
using LsportsAutomation.Pages.QuarterBack;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;



namespace LsportsAutomation.Tests.QuarterBack
{
    [AllureNUnit]
    [TestFixture]
    public class MarketsPageMainSearchTest : BaseTest
    {

        private string _marketName = "Most Run Outs";

        private string IDSearch="770";
        private string marketName = "Most Run Outs";
        private string marketFamily = "1X2";
        private string betGroup = "1,2,X";

     
        [Test]
        [AllureName("Validate Main Search in Markets")]
        [AllureTag("Quarter Back")]
        [Category("Markets")]
        [AllureDescription("Validate Main Search in Markets")]
        public void MainSearchByMarketName()
        {

            AppConfiguration appConfiguration = new AppConfiguration();
            appConfiguration.ReadConfigFile(out string URL, out string user, out string pass);

            var headerElements = new List<string>();
            headerElements.Add("ID");
            headerElements.Add("Market Name");
            headerElements.Add("Market Family");
            headerElements.Add("Bet Group");
            headerElements.Add("Stage");

            ConsoleReporter.Log("Step - 1 Login to Quarter Back");
            LoginPageQB loginPageQB = new LoginPageQB(Driver, Wait);
            loginPageQB.LoginToQarterBack(user, pass, URL);

            ConsoleReporter.Log("Step - 2 Navigate to Market Editor page");
            MarketEditorPage marketEditorPage = new MarketEditorPage(Driver, Wait);
            marketEditorPage.NavigateToMarketEditorPage();

            ConsoleReporter.Log($"Step - 3 Search By Market Name : {_marketName}");
            marketEditorPage.GetAppTopMenuComponent().InsertTextSearchFieldClickSearch(Wait,_marketName);

            ConsoleReporter.Log($"Step - 4 Verify Search BY Market Name : {_marketName}");
            marketEditorPage.GetPTableComponent().GetTableHeaderElements(headerElements);
            marketEditorPage.GetPTableComponent().GetResultsFromSearch(IDSearch,marketName,marketFamily,betGroup);


            //Thread.Sleep(3000);
        }
    }
}