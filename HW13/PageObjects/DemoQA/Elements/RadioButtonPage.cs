using HW13.Common.WebElements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA.Elements
{
    public class RadioButtonPage : BaseDemoQAPage
    {
        private readonly MyWebElement _yesRadioButton = new(By.XPath("//label[@class='custom-control-label' and @for='yesRadio']"));
        private readonly MyWebElement _noRadioButton = new(By.Id("noRadio"));
        private readonly MyWebElement _impressiveRadioButton = new(By.XPath("//label[@class='custom-control-label' and @for='impressiveRadio']"));
        private readonly MyWebElement _resultElement = new(By.CssSelector("[class='mt-3']"));

        public bool IsYesRadioButtonEnabled() => _yesRadioButton.Enabled;

        public bool IsNoRadioButtonEnabled() => _noRadioButton.Enabled;

        public bool IsImpressiveRadioButtonEnabled() => _impressiveRadioButton.Enabled;
        
        public void ClickOnYesRadioButton() => _yesRadioButton.Click();

        public void ClickOnImpressiveRadioButton() => _impressiveRadioButton.Click();

        public string GetResultMessage() => _resultElement.Text;
    }
}
