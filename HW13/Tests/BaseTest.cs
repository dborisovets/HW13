using HW13.Common.Drivers;
using HW13.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HW13
{
    public class BaseTest
    {
        protected readonly string _baseUrl;

        public BaseTest(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public static Actions Actions => new(WebDriverFactory.Driver); // return instance of actions

        public static IJavaScriptExecutor JavaScriptExecutor => (IJavaScriptExecutor)WebDriverFactory.Driver; // return instance of IJavaScriptExecutor
       
        [OneTimeSetUp]
        public void BaseTestSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(_baseUrl);

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            WebDriverFactory.Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriverFactory.QuitDriver();
        }
    }
}