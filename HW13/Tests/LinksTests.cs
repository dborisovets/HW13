using HW13.Common.Drivers;
using HW13.Data;
using HW13.PageObjects.DemoQA.Elements;
using HW13.PageObjects.DemoQA;
using NUnit.Framework;

namespace HW13.Tests
{
    public class LinksTests : BaseTest
    {
        readonly LinksPage LinksPage = new();

        public LinksTests() : base(TestSettings.DemoQALinksPageUrl) { }

        [TearDown]
        public void TearDown() => WebDriverFactory.Driver.Navigate().Refresh();

        [Test]
        public void HomeLink()
        {
            LinksPage.ClickOnHomeLink();
            IReadOnlyCollection<string> windowHandles = WebDriverFactory.Driver.WindowHandles;
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.Last());
            var actualUrl = WebDriverFactory.Driver.Url;
            Assert.AreEqual(BaseDemoQAPage.DemoQaUrl, actualUrl);
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.First());
        }

        [Test]
        public void DynamicLink()
        {
            LinksPage.ClickOnHomeDynamicLink();
            IReadOnlyCollection<string> windowHandles = WebDriverFactory.Driver.WindowHandles;
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.Last());
            var actualUrl = WebDriverFactory.Driver.Url;
            Assert.AreEqual(BaseDemoQAPage.DemoQaUrl, actualUrl);
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.First());
        }

        [Test]
        public void CreatedLink()
        {
            LinksPage.ClickOnCreatedLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "201");
            Assert.AreEqual(actualStatusText, "Created");
        }

        [Test]
        public void NoContentLink()
        {
            LinksPage.ClickOnNoContentLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "204");
            Assert.AreEqual(actualStatusText, "No Content");
        }

        [Test]
        public void MovedLink()
        {
            LinksPage.ClickOnMovedLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "301");
            Assert.AreEqual(actualStatusText, "Moved Permanently");
        }

        [Test]
        public void BadRequestLink()
        {
            LinksPage.ClickOnBadReuestLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual("400", actualStatusCode);
            Assert.AreEqual("Bad Request", actualStatusText);
        }

        [Test]
        public void UnauthorizedLink()
        {
            LinksPage.ClickOnUnautorizedLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual("401", actualStatusCode);
            Assert.AreEqual("Unauthorized", actualStatusText);
        }

        [Test]
        public void ForbiddenLink()
        {
            LinksPage.ClickOnForbiddenLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual("403", actualStatusCode);
            Assert.AreEqual("Forbidden", actualStatusText);
        }

        [Test]
        public void NotFoundLink()
        {
            LinksPage.ClickOnNotFoundLink();
            var actualStatusCode = LinksPage.GetStatusCode();
            var actualStatusText = LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "404");
            Assert.AreEqual(actualStatusText, "Not Found");
        }
    }
}
