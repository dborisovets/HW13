using HW13.Common.WebElements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA.Elements
{
    public class CheckBoxPage : BaseDemoQAPage
    {
        private readonly MyWebElement _homeCheckbox = new(By.XPath("//input[@id='tree-node-home']/following-sibling::span[@class='rct-checkbox']"));
        private readonly MyWebElement _arrowHomeCheckbox = new(By.XPath("//button[@title='Toggle']"));
        private readonly MyWebElement _desktopCheckbox = new(By.XPath("//label[@for='tree-node-desktop']//span[@class='rct-checkbox']"));
        private readonly MyWebElement _documentsCheckbox = new(By.XPath("//label[@for='tree-node-documents']//span[@class='rct-checkbox']"));
        private readonly MyWebElement _downloadsCheckbox = new(By.XPath("//label[@for='tree-node-downloads']//span[@class='rct-checkbox']"));
        private readonly MyWebElement _noticationMessage = new(By.XPath("//*[@id='result']"));

        public Boolean IsHomeCheckBoxDisplayed() => _homeCheckbox.Displayed;
        
        public Boolean IsDesktopCheckboxDisplayed() => _desktopCheckbox.Displayed;
        
        public Boolean IsDocumentsCheckboxDisplayed() => _documentsCheckbox.Displayed;

        public Boolean IsDownloadsCheckboxDisplayed() => _downloadsCheckbox.Displayed;
        
        public void ExpandHomeCheckBox() => _arrowHomeCheckbox.Click();
        
        public void HomeCheckBoxCkick() => _homeCheckbox.Click();

        public string GetNotificationMessage() => _noticationMessage.Text.Replace("\r\n", " ");
    }
}
