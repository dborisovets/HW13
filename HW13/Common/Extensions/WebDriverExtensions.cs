using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HW13.Common.Extensions
{
    public static class WebDriverExtensions
    {
        // extensions method to get WebDriverWait
        // 'this Iwebdriver driver' shows that this method extends IwebDriver functionality
        public static WebDriverWait GetWebDriverWait(this IWebDriver driver, int timeoutSeconds = 30, TimeSpan? pollingInterval = null, params Type[] exceptionTypes)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            if (pollingInterval != null) // we can set our custom polling interval (e.g. Timespan.FromSeconds(5)) 
            {
                webDriverWait.PollingInterval = (TimeSpan)pollingInterval;
            }
            webDriverWait.IgnoreExceptionTypes(exceptionTypes); // allows us to ignore any type of exception (e.g. StaleElementsReferenceException)
            
            return webDriverWait;
        }
        // extension method to perform FindElement with explicit wait
        public static IWebElement GetWebElementWhenExist(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElement(by));
    }
}
