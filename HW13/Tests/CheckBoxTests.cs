using HW13.Common.Drivers;
using HW13.Data;
using HW13.Data.Constants;
using HW13.PageObjects.DemoQA.Elements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Tests
{
    public class CheckBoxTests : BaseTest
    {
        readonly CheckBoxPage CheckBoxPage = new();

        public CheckBoxTests() : base(TestSettings.DemoQACheckBoxPageUrl) { }

        [Test]
        public void HomeCheckbox() => Assert.IsTrue(CheckBoxPage.IsHomeCheckBoxDisplayed());

        [Test]
        public void ExpandHomeCheckBox()
        {
            CheckBoxPage.ExpandHomeCheckBox();
            Assert.IsTrue(CheckBoxPage.IsDesktopCheckboxDisplayed());
            Assert.IsTrue(CheckBoxPage.IsDocumentsCheckboxDisplayed());
            Assert.IsTrue(CheckBoxPage.IsDownloadsCheckboxDisplayed());
        }

        [Test]
        public void SelectHomeCheckBox()
        {
            CheckBoxPage.HomeCheckBoxCkick();
            var actualMessage = CheckBoxPage.GetNotificationMessage();
            Assert.AreEqual(actualMessage, DemoQACategories.expectedMessage);
        }
    }
}
