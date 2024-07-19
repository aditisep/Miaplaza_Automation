using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace SeleniumNUnitPOM.Tests

{
    [TestFixture]
    public abstract class BaseTest : IDisposable
    {
        protected IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize(); // Maximize the window
        }

        [TearDown]
        public void Teardown()
        {
            Dispose();
        }

        public void Dispose()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}
