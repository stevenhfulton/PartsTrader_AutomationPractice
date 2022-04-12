using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PartsTrader_AutomationPractice.Helpers;

namespace PartsTrader_AutomationPractice.StepDefinitions
{
    internal class ContactUsElements
    {
        internal static void SelectXAsTheHeading(WebDriverContext _webdriverContext, string subjectHeading)
        {
            new SelectElement(_webdriverContext.driver.FindElementWithWait(By.CssSelector("select[id='id_contact']"))).SelectByText(subjectHeading);
        }

        internal static void EnterXAsTheEmailAddress(WebDriverContext _webdriverContext, string emailAddress)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("input[id='email']")).SendKeys(emailAddress);
        }

        internal static void EnterXAsTheOrderNumber(WebDriverContext _webdriverContext, string orderNumber)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("input[id='id_order']")).SendKeys(orderNumber);
        }

        internal static void EnterXAsTheMessage(WebDriverContext _webdriverContext, string message)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("textarea[id='message']")).SendKeys(message);
        }

        internal static void ConfirmConfirmationMessageIsDisplayed(WebDriverContext _webdriverContext)
        {
            string confirmationMessage = _webdriverContext.driver.FindElementWithWait(By.CssSelector("p[class='alert alert-success']")).Text;
            Assert.AreEqual("Your message has been successfully sent to our team.", confirmationMessage);
        }
    }
}