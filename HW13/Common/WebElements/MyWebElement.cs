using HW13.Common.Drivers;
using HW13.Common.Extensions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace HW13.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExist(By);

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public IWebElement WrappedElement => throw new NotImplementedException();

        public MyWebElement (By by)
        {
            By = by;
        }

        public void Clear() => WebElement.Clear();

        public void Click()
        {
            try
            {
                WebElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                WebElement.Click();
            }
        }

        public void RightClick() => BaseTest.Actions.ContextClick(WebElement).Build().Perform();

        public void DoubleClick() => BaseTest.Actions.DoubleClick(WebElement).Build().Perform();

        public IWebElement FindElement(By by) => WebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => WebElement.FindElements(by);

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetCssvalue(string propertyName) => WebElement.GetCssValue(propertyName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public ISearchContext GetshadomRoot() => WebElement.GetShadowRoot();

        public void Submit() => WebElement.Submit();

        public void ScrollIntoView() => BaseTest.JavaScriptExecutor.ExecuteScript("arguments [0].scrollIntoView()", WebElement);

        public string GetValueofClassAttribute() => GetAttribute("class");

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }
    }
}
