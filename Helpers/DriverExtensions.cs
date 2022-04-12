using OpenQA.Selenium;

namespace PartsTrader_AutomationPractice.Helpers
{
    public static class DriverExtensions
    {
        public static IWebElement FindElementWithWait(this WebDriver driver, By by, int waitTime = 30)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTime);
            return driver.FindElement(by);
        }

        public static IWebElement FindElementWithSleep(this WebDriver driver, By by, int waitTime = 3500)
        {
            Thread.Sleep(waitTime);
            return driver.FindElement(by);
        }
    }
}
