using HW13.Data;
using HW13.PageObjects.DemoQA.Elements;
using NUnit.Framework;

namespace HW13.Tests
{
    public class WebTablesTests : BaseTest
    {
        readonly WebTablesPage WebTablesPage = new();

        public WebTablesTests() : base(TestSettings.DemoQAWebTablesPageUrl) { }

        [Test]
        public void WebTablesReady() => Assert.IsTrue(WebTablesPage.IsWebTablesPageWorkable());

        [Test]
        public void AddNewMember()
        {
            WebTablesPage.AddNewMember("Adam", "Smith", "test@test.com", "29", "3000", "test");
            var actualResult = WebTablesPage.IsMemberExistInTable("Adam");
            Assert.IsTrue(actualResult);
        }
    }
}
