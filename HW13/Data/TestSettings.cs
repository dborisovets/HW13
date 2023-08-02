using HW13.Data.Enums;
using Microsoft.Extensions.Configuration;

namespace HW13.Data
{
    public static class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string? UserName { get; set; }
        public static string? UserEmail { get; set; }
        public static string? DemoQAButtonPageUrl { get; set; }
        public static string? DemoQACheckBoxPageUrl { get; set; }
        public static string? DemoQARadioButtonPageUrl { get; set; }
        public static string? DemoQAWebTablesPageUrl { get; set; }
        public static string? DemoQALinksPageUrl { get; set; }

        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            UserName = TestConfiguration["TestData:UserName"];
            UserEmail = TestConfiguration["TestData:UserEmail"];
            DemoQAButtonPageUrl = TestConfiguration["Common:DemoQAUrls:Buttons"];
            DemoQACheckBoxPageUrl = TestConfiguration["Common:DemoQAUrls:Checkbox"];
            DemoQARadioButtonPageUrl = TestConfiguration["Common:DemoQAUrls:RadioButton"];
            DemoQAWebTablesPageUrl = TestConfiguration["Common:DemoQAUrls:Webtables"];
            DemoQALinksPageUrl = TestConfiguration["Common:DemoQAUrls:Links"];
        }
    }
}
