using HW13.Common.WebElements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA.Elements
{
    public class LinksPage : BaseDemoQAPage
    {

        private readonly MyWebElement _homeLink = new(By.Id("simpleLink"));
        private readonly MyWebElement _homeDynamicLink = new(By.XPath("//*[@id='dynamicLink']"));
        private readonly MyWebElement _createdLink = new(By.Id("created"));
        private readonly MyWebElement _noContentLink = new(By.Id("no-content"));
        private readonly MyWebElement _movedLink = new(By.Id("moved"));
        private readonly MyWebElement _badRequestLink = new(By.XPath("//*[@id='bad-request']"));
        private readonly MyWebElement _unauthorizedLink = new(By.Id("unauthorized"));
        private readonly MyWebElement _forbiddenLink = new(By.Id("forbidden"));
        private readonly MyWebElement _notFoundLink = new(By.Id("invalid-url"));
        private readonly MyWebElement _statusCode = new(By.XPath("(//*[@id='linkResponse']/b)[1]"));
        private readonly MyWebElement _statusText = new(By.XPath("(//*[@id='linkResponse']/b)[2]"));

        public void ClickOnHomeLink() => _homeLink.ClickAndWait();

        public void ClickOnHomeDynamicLink() => _homeDynamicLink.ClickAndWait();

        public void ClickOnCreatedLink() => _createdLink.ClickAndWait();

        public void ClickOnNoContentLink() => _noContentLink.ClickAndWait();
        
        public void ClickOnMovedLink() => _movedLink.ClickAndWait();

        public void ClickOnBadReuestLink() => _badRequestLink.ClickAndWait();

        public void ClickOnUnautorizedLink() => _unauthorizedLink.ClickAndWait();

        public void ClickOnForbiddenLink() => _forbiddenLink.ClickAndWait();

        public void ClickOnNotFoundLink() => _notFoundLink.ClickAndWait();

        public String GetStatusCode() => _statusCode.Text;     
        
        public String GetStatusText() => _statusText.Text;      
           

    }
}
