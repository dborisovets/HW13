using HW13.Common.Drivers;
using HW13.Data;
using NUnit.Framework;

namespace HW13
{

    public class BaseTest
    {

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