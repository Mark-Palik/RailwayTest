using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace TestingRailway
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _inputField = By.XPath("//input[@name = 'q']");
        private readonly By _searchButton = By.XPath("//input[@class = 'gNO89b']");
        private readonly By _targetLink = By.XPath("//a[@href = 'https://www.rw.by/']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com/");
            driver.Manage().Window.Maximize();
            

        }

        [Test]
        public void Test1()
        {
            var inputField = driver.FindElement(_inputField);
            inputField.SendKeys("белорусская железная дорога");
            Thread.Sleep(1000);
            var searchButton = driver.FindElement(_searchButton);
            searchButton.Click();
            var targetLink = driver.FindElement(_targetLink);
            targetLink.Click();
            Assert.Pass();
        }
    }
}