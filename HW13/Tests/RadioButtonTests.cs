using HW13.Data;
using HW13.Data.Constants;
using HW13.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace HW13.Tests
{
    public class RadioButtonTests : BaseTest
    {
        readonly RadioButtonPage RadioButtonPage = new();

        public RadioButtonTests() : base(TestSettings.DemoQARadioButtonPageUrl) { }

        [Test]
        public void CheckThatYesRadioButtonEnabled()
        {
            var actualResult = RadioButtonPage.IsYesRadioButtonEnabled();
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void CheckThatNoRadioButtonDisabled()
        {
            var actualResult = RadioButtonPage.IsNoRadioButtonEnabled();
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void CheckThatImressiveRadioButtonEnabled()
        {
            var actualResult = RadioButtonPage.IsImpressiveRadioButtonEnabled();
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void SelectYesRadioButton()
        {
            RadioButtonPage.ClickOnYesRadioButton();
            var actualMessage = RadioButtonPage.GetResultMessage();
            Assert.AreEqual(DemoQACategories.SelectedYesMessage, actualMessage);
        }

        [Test]
        public void SelectImressiveRadioButton()
        {
            RadioButtonPage.ClickOnImpressiveRadioButton();
            var actualMessage = RadioButtonPage.GetResultMessage();
            Assert.AreEqual(DemoQACategories.SelectedImressiveMessage, actualMessage);
        }
    }
}
