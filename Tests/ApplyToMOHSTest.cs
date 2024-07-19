using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitPOM.Pages;
namespace SeleniumNUnitPOM.Tests
{
    [TestFixture]
    public class ApplyToMOHSTest : BaseTest
    {

        [Test]
        public void NavigateToMOHSAndApply()
        {
            _driver.Navigate().GoToUrl("https://miacademy.co/#/");

            var miaAcademyHomePage = new MiaAcademyHomePage(_driver);
            var miaPrepOnlineSchoolPage = new MiaPrepOnlineSchoolPage(_driver);
            var mohsApplicationPage = new MOHSApplicationPage(_driver);

            miaAcademyHomePage.NavigateToMOHS();
            miaPrepOnlineSchoolPage.ClickOnApplyNow();
            mohsApplicationPage.ParentFormFirstTab();
            mohsApplicationPage.TabParentInformation();
            mohsApplicationPage.StudentInformation();
            Assert.IsTrue(mohsApplicationPage.StudentInformationTab.Displayed, "Complete the automation since parent information is filled up");
        }
    }
}
