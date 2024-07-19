using OpenQA.Selenium;
using System.Threading;

namespace SeleniumNUnitPOM.Pages
{
    public class MOHSApplicationPage
    {
        private readonly IWebDriver _driver;

        public MOHSApplicationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Parent's information to fill the form.
        private IWebElement ClickOnNextForForm => _driver.FindElement(By.XPath("(//*[contains(@aria-label, 'Next')])[1]"));
        private IWebElement ParentFname => _driver.FindElement(By.XPath("//*[@complink='Name_First']"));
        private IWebElement ParentLname => _driver.FindElement(By.XPath("//*[@complink='Name_Last']"));
        private IWebElement ParentEmail => _driver.FindElement(By.XPath("//*[@name='Email']"));
        private IWebElement ParentCountyCode => _driver.FindElement(By.XPath("//*[@class='selected-dial-code']"));
        private IWebElement ParentPhoneNumber => _driver.FindElement(By.Id("PhoneNumber"));
        private IWebElement SecondParentInfo => _driver.FindElement(By.Id("select2-Dropdown-arialabel-container"));
        private IWebElement SecondParentInfoNO => _driver.FindElement(By.XPath("//li[text()='No']"));
        private IWebElement HeardBySearchEngine => _driver.FindElement(By.CssSelector("[for='Checkbox_1']"));
        private IWebElement OtherSocialMedia => _driver.FindElement(By.CssSelector("[for='Checkbox_10']"));
        private IWebElement PreferredStartDate => _driver.FindElement(By.Name("Date"));
        private IWebElement ParentNextButton => _driver.FindElement(By.XPath("(//*[contains(@aria-label,'Next')])[2]"));
        public IWebElement StudentInformationTab => _driver.FindElement(By.XPath("//b[contains(text(),'Student Information')]"));

        public void ParentFormFirstTab()
        {
            ClickOnNextForForm.Click();
        }
        public void StudentInformation()
        {
            StudentInformationTab.Click();
        }

        public void TabParentInformation()
        {
            ParentFname.SendKeys("Aditi");
            ParentLname.SendKeys("Patil");
            ParentEmail.SendKeys("parent20@gmail.com");
            ParentPhoneNumber.SendKeys("9435367890");
            SecondParentInfo.Click();
            SecondParentInfoNO.Click();
            HeardBySearchEngine.Click();
            OtherSocialMedia.Click();
            PreferredStartDate.SendKeys("21-Aug-2024");
            Thread.Sleep(5000);
            ParentNextButton.Click();
            Thread.Sleep(1000);
           
        }
    }
}
