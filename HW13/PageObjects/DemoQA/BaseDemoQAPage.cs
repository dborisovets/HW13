using HW13.Common.Drivers;
using HW13.Common.WebElements;
using HW13.PageObjects.DemoQA.Elements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA
{
    public class BaseDemoQAPage
    {
        public const string DemoQaUrl = "https://demoqa.com/";
        private readonly MyWebElement _buttons = new(By.XPath("//li[contains(@id, 'item-4')]/span[contains(text(), 'Buttons')]"));
        //private readonly MyWebElement _buttons = new(By.XPath("//li[@id='item-4']/span[contains(text(), 'Buttons')]"));

        public ButtonsPage GetButtonsPage()
        {
            _buttons.Click();

            return new ButtonsPage();
        }
    }
}
