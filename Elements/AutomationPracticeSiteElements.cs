using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PartsTrader_AutomationPractice.Helpers;

namespace PartsTrader_AutomationPractice.StepDefinitions
{
    internal class AutomationPracticeSiteElements
    {
        internal static void SearchForX(WebDriverContext _webdriverContext, string product)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("#search_query_top")).SendKeys(product);
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("button[name='submit_search']")).Click();
        }

        internal static void ConfirmNumberOfProductsFound(WebDriverContext _webdriverContext, string expectedNumberOfProducts)
        {
            string resultCount = _webdriverContext.driver.FindElementWithWait(By.CssSelector(".heading-counter")).Text;
            Assert.AreEqual(resultCount, expectedNumberOfProducts + " results have been found.");
        }

        internal static void SortResultsByX(WebDriverContext _webdriverContext, string sortBy)
        {
            new SelectElement(_webdriverContext.driver.FindElementWithWait(By.CssSelector($".selectProductSort"))).SelectByText(sortBy);          
        }

        internal static void QuickViewTheFirstItem(WebDriverContext _webdriverContext)
        {
            _webdriverContext.driver.FindElementWithWait(By.XPath("//li[contains(concat(' ',normalize-space(@class),''),'first-in-line')] [1]")).Click();
        }

        internal static void ConfirmProductName(WebDriverContext _webdriverContext, string expectedProductName)
        {
            string actualProductName = _webdriverContext.driver.FindElementWithWait(By.CssSelector("h1[itemprop='name']")).Text;
            Assert.AreEqual(expectedProductName, actualProductName);
        }

        internal static void EnterXAsTheQuantity(WebDriverContext _webdriverContext, string quantityWanted)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("input[name='qty']")).Clear();
            _webdriverContext.driver.FindElementWithWait(By.CssSelector("input[name='qty']")).SendKeys(quantityWanted);
        }

        internal static void SetTheSizeToX(WebDriverContext _webdriverContext, string requiredSize)
        {
            new SelectElement(_webdriverContext.driver.FindElementWithWait(By.CssSelector("select[name='group_1']"))).SelectByText(requiredSize);
        }

        internal static void SelectTheXColour(WebDriverContext _webdriverContext, string colour)
        {
            _webdriverContext.driver.FindElementWithWait(By.CssSelector($"a[name = '{colour}']")).Click();
        }

        internal static void ConfirmSelectedColourIsX(WebDriverContext _webdriverContext, string expectedColour)
        {
            string actualColour = _webdriverContext.driver.FindElementWithWait(By.XPath("//li[@class='selected'] /a")).GetAttribute("title").ToString();
            Assert.AreEqual(expectedColour, actualColour);
        }

        internal static void ConfirmXHasBeenAddedToTheCart(WebDriverContext _webdriverContext, string productName)
        {
            string actualProductAdded = _webdriverContext.driver.FindElementWithSleep(By.CssSelector(".layer_cart_product_info > .product-name")).Text;
            Assert.AreEqual(productName, actualProductAdded);
        }

        internal static void ConfirmTotalAmountIsX(WebDriverContext _webdriverContext, string expectedTotalAmount)
        {
            string actualProductAdded = _webdriverContext.driver.FindElementWithWait(By.CssSelector("#total_price")).Text;
            Assert.AreEqual(expectedTotalAmount, actualProductAdded);
        }
    }
}