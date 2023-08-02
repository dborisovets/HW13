using HW13.Data;
using HW13.Data.Constants;
using HW13.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace HW13
{
    public class ButtonsTests : BaseTest
    {
        readonly ButtonsPage ButtonsPage = new();

        public ButtonsTests() : base(TestSettings.DemoQAButtonPageUrl) { }

        [Test]
        public void DoubleClickMeButton()
        {
            ButtonsPage.DoubleClickOnDoubleClickButton();
            var actualMessage = ButtonsPage.GetDoubleClickMessage();
            Assert.AreEqual(actualMessage, DemoQACategories.doubleClickmeButtonMessage);
        }

        [Test]
        public void RightClickMeButton()
        {   
            ButtonsPage.RightClickOnRightClickMeButton();
            var actualMessage = ButtonsPage.GetRightClickMessage();
            Assert.AreEqual(actualMessage, DemoQACategories.rightClickmeButtonMessage);
        }

        [Test]
        public void ClickMeButton()
        {
            ButtonsPage.SingleClickOnClickMeButton();
            var actualMessage = ButtonsPage.GetDynamicClickMessage();
            Assert.AreEqual(actualMessage, DemoQACategories.clickmeButtonMessage);
        }
    }
}