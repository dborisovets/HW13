using HW13.Common.WebElements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA.Elements
{
    public class ButtonsPage : BaseDemoQAPage
    {
        public const string doubleClickmeButtonMessage = "You have done a double click";
        public const string rightClickmeButtonMessage = "You have done a right click";
        public const string clickmeButtonMessage = "You have done a dynamic click";

        private readonly MyWebElement _doubleClickmeButton = new (By.Id("doubleClickBtn"));
        private readonly MyWebElement _rightClickmeButton = new (By.Id("rightClickBtn"));
        private readonly MyWebElement _clickmeButton = new (By.XPath("//button[@id='rightClickBtn']/parent::div/following-sibling::div/button"));
        
        private readonly MyWebElement _doubleClickMessage = new (By.Id("doubleClickMessage"));
        private readonly MyWebElement _rightClickMessage = new (By.Id("rightClickMessage"));
        private readonly MyWebElement _dynamicClickMessage = new(By.Id("dynamicClickMessage"));

        public void DoubleClickOnDoubleClickButton() => _doubleClickmeButton.DoubleClick();
       
        public void RightClickOnRightClickMeButton() => _rightClickmeButton.RightClick();

        public void SingleClickOnClickMeButton() => _clickmeButton.Click();

        public String GetDoubleClickMessage() => _doubleClickMessage.Text;

        public String GetRightClickMessage() => _rightClickMessage.Text;

        public String GetDynamicClickMessage() => _dynamicClickMessage.Text;

    }
}
