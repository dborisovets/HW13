using HW13.Common.Drivers;
using HW13.Data;
using HW13.PageObjects.DemoQA;
using HW13.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace HW13

{
    public class ButtonsTests : BaseTest
    {
        readonly ButtonsPage ButtonsPage = new();

        [OneTimeSetUp]
        public void ButtonsTestsSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQAButtonPageUrl);

        [Test]
        public void DoubleClickMeButton()
        {
            ButtonsPage.DoubleClickOnDoubleClickButton();
            var actualMessage = ButtonsPage.GetDoubleClickMessage();
            Assert.AreEqual(actualMessage, ButtonsPage.doubleClickmeButtonMessage);
        }

        [Test]
        public void RightClickMeButton()
        {   
            ButtonsPage.RightClickOnRightClickMeButton();
            var actualMessage = ButtonsPage.GetRightClickMessage();
            Assert.AreEqual(actualMessage, ButtonsPage.rightClickmeButtonMessage);
        }

        [Test]
        public void ClickMeButton()
        {
            ButtonsPage.SingleClickOnClickMeButton();
            var actualMessage = ButtonsPage.GetDynamicClickMessage();
            Assert.AreEqual(actualMessage, ButtonsPage.clickmeButtonMessage);
        }

    }

    public class RadioButtonTests : BaseTest
    {
        readonly RadioButtonPage _RadioButtonPage = new();

        [OneTimeSetUp]
        public void RadioButtonTestsSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQARadioButtonPageUrl);

        [Test]
        public void CheckThatYesRadioButtonEnabled()
        {       
            var actualResult = _RadioButtonPage.IsYesRadioButtonEnabled();
            Assert.IsTrue(actualResult);         
        }

        [Test]
        public void CheckThatNoRadioButtonDisabled()
        {
            var actualResult = _RadioButtonPage.IsNoRadioButtonEnabled();
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void CheckThatImressiveRadioButtonEnabled()
        {
            var actualResult = _RadioButtonPage.IsImpressiveRadioButtonEnabled();
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void SelectYesRadioButton()
        {
            _RadioButtonPage.ClickOnYesRadioButton();
            var actualMessage = _RadioButtonPage.GetResultMessage();
            Assert.AreEqual(actualMessage, RadioButtonPage.SelectedYesMessage);
        }

        [Test]
        public void SelectImressiveRadioButton()
        {
            _RadioButtonPage.ClickOnImpressiveRadioButton();
            var actualMessage = _RadioButtonPage.GetResultMessage();
            Assert.AreEqual(actualMessage, RadioButtonPage.SelectedImressiveMessage);
        }

    }

    public class WebTablesTests : BaseTest
    {
        readonly WebTablesPage _webTablesPage = new();

        [OneTimeSetUp]
        public void WebTablesTestsSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQAWebTablesPageUrl);


        [Test]
        public void WebTablesReady() => Assert.IsTrue(_webTablesPage.IsWebTablesPageWorkable());
        
        [Test]
        public void AddNewMember()
        {
            _webTablesPage.AddNewMember("Adam", "Smith", "test@test.com", "29", "3000", "test");
            var actualResult = _webTablesPage.isMemberExistInTable("Adam");
            Assert.IsTrue(actualResult);
        }
    }

    public class LinksTests : BaseTest
    {
        readonly LinksPage _LinksPage = new();

        [OneTimeSetUp]
        public void LinksTestsSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQALinksPageUrl);

        [Test]
        public void HomeLink()
        {
            _LinksPage.ClickOnHomeLink();
            IReadOnlyCollection<string> windowHandles = WebDriverFactory.Driver.WindowHandles;
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.Last());
            var actualUrl = WebDriverFactory.Driver.Url;
            Assert.AreEqual(BaseDemoQAPage.DemoQaUrl, actualUrl);
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.First());
        }

        [Test]
        public void DynamicLink()
        {
            _LinksPage.ClickOnHomeDynamicLink();
            IReadOnlyCollection<string> windowHandles = WebDriverFactory.Driver.WindowHandles;
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.Last());
            var actualUrl = WebDriverFactory.Driver.Url;
            Assert.AreEqual(BaseDemoQAPage.DemoQaUrl, actualUrl);
            WebDriverFactory.Driver.SwitchTo().Window(windowHandles.First());
        }

        [Test]
        public void CreatedLink()
        {
            _LinksPage.ClickOnCreatedLink();
            var actualStatusCode = _LinksPage.GetStatusCode(); 
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "201");
            Assert.AreEqual(actualStatusText, "Created");
            
        }

        [Test]
        public void NoContentLink()
        {
            _LinksPage.ClickOnNoContentLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "204");
            Assert.AreEqual(actualStatusText, "No Content");
        }

        [Test]
        public void MovedLink()
        {
            _LinksPage.ClickOnMovedLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "301");
            Assert.AreEqual(actualStatusText, "Moved Permanently");
        }

        [Test]
        public void BadRequestLink()
        {
            _LinksPage.ClickOnBadReuestLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual("400", actualStatusCode);
            Assert.AreEqual("Bad Request", actualStatusText);
        }

        [Test]
        public void UnauthorizedLink()
        {
            _LinksPage.ClickOnUnautorizedLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual("401", actualStatusCode);
            Assert.AreEqual("Unauthorized", actualStatusText);
        }

        [Test]
        public void ForbiddenLink()
        {
            _LinksPage.ClickOnForbiddenLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual("403", actualStatusCode);
            Assert.AreEqual("Forbidden", actualStatusText);
        }

        [Test]
        public void NotFoundLink()
        {
            _LinksPage.ClickOnNotFoundLink();
            var actualStatusCode = _LinksPage.GetStatusCode();
            var actualStatusText = _LinksPage.GetStatusText();
            Assert.AreEqual(actualStatusCode, "404");
            Assert.AreEqual(actualStatusText, "Not Found");
        }

    }

    public class CheckBoxTests : BaseTest
    {
        readonly CheckBoxPage CheckBoxPage = new();

        [OneTimeSetUp]
        public void CheckBoxTestsSetUp() => WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DemoQACheckBoxPageUrl);

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
            Assert.AreEqual(actualMessage, CheckBoxPage.expectedMessage);
        }

    }

}