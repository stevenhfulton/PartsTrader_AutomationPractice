using NUnit.Framework;
using OpenQA.Selenium;
using PartsTrader_AutomationPractice.Helpers;
using System.Text.RegularExpressions;

namespace PartsTrader_AutomationPractice.StepDefinitions
{
    internal class SharedElements
    {
        internal static void ConfirmPageTitleIsX(WebDriverContext _webdriverContext, string expectedTitle)
        {
            string actualTitle = _webdriverContext.driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        internal static void IPressTheXButton(WebDriverContext _webdriverContext, string buttonText)
        {
            _webdriverContext.driver.FindElementWithWait(By.XPath($"//span [contains(text(),'{buttonText}')]")).Click();
        }

        internal static void SaveAScreenshot(WebDriverContext _webdriverContext)
        {
            Screenshot image = ((ITakesScreenshot)_webdriverContext.driver).GetScreenshot();
            string timeStamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            image.SaveAsFile("../../../Screenshots/" + Regex.Replace(timeStamp, "[^0-9]", "") + ".jpeg", ScreenshotImageFormat.Jpeg);
        }

        internal static void IPressTheXLink(WebDriverContext _webdriverContext, string linkText)
        {
            _webdriverContext.driver.FindElementWithSleep(By.LinkText(linkText)).Click();
        }
    }
}