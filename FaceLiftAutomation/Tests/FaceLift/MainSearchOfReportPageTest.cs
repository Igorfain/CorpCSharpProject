using LsportsAutomation.Infra;
using LsportsAutomation.Pages.FaceLift;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace LsportsAutomation.Tests.FaceLift
{
    [AllureNUnit]
    [TestFixture]
    [Ignore("NotRelevantTest - for example only")]
    public class MainSearchOfReportPageTest : BaseTest
    {
        private const string pageUrl = "https://stm.qa.lsports.cloud/";
        private const string userEmail = "Automations@lsports.eu";
        private const string password = "Automation123!@";
        private string fixtureId = "6491236";
        private string landingPageBreadCrumbsAttribute = "Trading Floor / InPlay";


        [Test]
        [AllureName("Validate Main Search in Report Page")]
        [AllureTag("UI")]
        [Category("Reports page")]

        [AllureDescription("Validate main search in report page")]

        public void ValidateMainSearchInReportPage()
        {
            ConsoleReporter.Log("Step 1 - Login and validate on landing page");
            LoginPageFaceLift loginPage = new LoginPageFaceLift(Driver, Wait);
            HomePage homePage = new HomePage(Driver, Wait);
            ReportPage reportPage = new ReportPage(Driver, Wait);
            Logout logout = new Logout(Driver, Wait);

            loginPage.LoginFaceLift(pageUrl, userEmail, password);
            homePage.GetAppTopMenuComponent(Driver, Wait).IsLandingPageBreadCrumbsDisplayed(landingPageBreadCrumbsAttribute);

            ConsoleReporter.Log("Step 2 - Navigate to Report Page");
            loginPage.NavigateToReportsPage();
            loginPage.GetLsportsUiSideMenuComponent().ToggleButtonExpandExpand();
            ConsoleReporter.Log("Step 3 - Search Fixture by ID");
            loginPage.GetLsportsUiSideMenuComponent().ToggleButtonExpandClose();
            reportPage.GetAppTopMenuComponent(Driver, Wait).TextSearchFieldAndSearch(Wait, fixtureId);

            ConsoleReporter.Log("Logout");
            logout.LogoutFaceLift();
        }


    }


}

