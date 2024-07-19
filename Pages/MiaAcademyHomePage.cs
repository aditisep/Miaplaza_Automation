using OpenQA.Selenium;
namespace SeleniumNUnitPOM.Pages
{
    public class MiaAcademyHomePage
    {
        private readonly IWebDriver _driver;

        public MiaAcademyHomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement OnlineHighSchool => _driver.FindElement(By.XPath("//a[contains(text(),'Online High School')]"));
        // public IWebElement ApplyNowLink => _driver.FindElement(By.XPath("//a[contains(@href,'https://forms.zohopublic.com')]"));

        public void NavigateToMOHS()
        {
            OnlineHighSchool.Click();
        }


    }
}
