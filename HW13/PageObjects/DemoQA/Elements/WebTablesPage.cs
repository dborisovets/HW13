using HW13.Common.WebElements;
using OpenQA.Selenium;

namespace HW13.PageObjects.DemoQA.Elements
{
    public class WebTablesPage : BaseDemoQAPage
    {
        private readonly MyWebElement _table = new(By.XPath("//div[@class='ReactTable -striped -highlight']"));
        private readonly MyWebElement _searchBox = new(By.Id("searchBox"));
        private readonly MyWebElement _addButton = new(By.Id("addNewRecordButton"));
        private readonly MyWebElement _lastName = new(By.Id("lastName"));
        private readonly MyWebElement _firstName = new(By.Id("firstName"));
        private readonly MyWebElement _userEmail = new(By.Id("userEmail"));
        private readonly MyWebElement _age = new(By.Id("age"));
        private readonly MyWebElement _salary = new(By.Id("salary"));
        private readonly MyWebElement _department = new(By.Id("department"));
        private readonly MyWebElement _submit = new(By.Id("submit"));

        public Boolean IsWebTablesPageWorkable() => _table.Displayed  && _searchBox.Displayed && _addButton.Displayed;

        public void AddNewMember(string firstName, string lastName, string userEmail, string age,  string salary, string department)
        {
            _addButton.Click();
            _firstName.SendKeys(firstName);
            _lastName.SendKeys(lastName);
            _userEmail.SendKeys(userEmail);
            _age.SendKeys(age);
            _salary.SendKeys(salary);
            _department.SendKeys(department);
            _submit.Click();
        }

        public bool IsMemberExistInTable(string firstName)
        {
            _searchBox.SendKeys(firstName);
            var locator = $"//div[contains(text(),'{firstName}')]";
            MyWebElement expectedCell = new (By.XPath(locator));
            return expectedCell.Displayed;
        }
    }
}
