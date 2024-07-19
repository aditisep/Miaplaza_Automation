using OpenQA.Selenium;
namespace SeleniumNUnitPOM.Pages
{
    public class MiaPrepOnlineSchoolPage
    {
        private readonly IWebDriver _driver;

        public MiaPrepOnlineSchoolPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement ApplyNowLink => _driver.FindElement(By.XPath("//a[contains(@href,'https://forms.zohopublic.com')]"));

        public void ClickOnApplyNow()
        {
            ApplyNowLink.Click();

        }
    }
}
