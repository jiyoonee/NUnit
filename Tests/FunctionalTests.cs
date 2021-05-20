using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace NETTests.Tests
{
    class FunctionalTests
    {
        IWebDriver driver;

        [SetUp]
        public void InitializeTest()
        {
            driver = new FirefoxDriver(@"C:\Users\t-juliesong\.nuget\packages\selenium.firefox.webdriver\0.27.0\driver");;
        }
        
        [Test]
        public void TitleTest()
        {
            driver.Url = "https://t-juliesongcloud-staging.azurewebsites.net/";
            IWebElement element = driver.FindElement(By.Id("title"));
            String val = element.GetAttribute("innerText");
            Assert.IsTrue(val.Contains("asdf"));
        }

        [Test]
        public void OpenAppTest()
        {
            Console.WriteLine("Opening site at URL...");
            driver.Url = "https://t-juliesongcloud-staging.azurewebsites.net/";
        }
        
        [Test]
        public void HomeExistCheck()
        {
            Console.WriteLine("Finding Home Button...");
            driver.Url = "https://t-juliesongcloud-staging.azurewebsites.net/";
            driver.FindElement(By.Id("home-button"));
        }

        [Test]
        public void AboutExistCheck()
        {
            Console.WriteLine("Finding About Button...");
            driver.Url = "https://t-juliesongcloud-staging.azurewebsites.net/";
            driver.FindElement(By.Id("about-button"));
        }

        [Test]
        public void ContactExistCheck()
        {
            Console.WriteLine("Finding Contact Button...");
            driver.Url = "https://t-juliesongcloud-staging.azurewebsites.net/";
            driver.FindElement(By.Id("contact-button"));
        }

        [TearDown]
        public void EndTest()
        {
            Console.WriteLine("Closing driver...");
            driver.Close();
        }
    }
}
