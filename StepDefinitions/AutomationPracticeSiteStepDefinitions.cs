namespace PartsTrader_AutomationPractice.StepDefinitions
{
    [Binding]
    public sealed class AutomationPracticeSteps
    {
        private readonly WebDriverContext _webdriverContext;

        public AutomationPracticeSteps(WebDriverContext webdriverContext)
        {
            this._webdriverContext = webdriverContext;
        }

        [Given(@"I navigate to the Automation Practice website")]
        public void GivenINavigateToTheAutomationPracticeWebsite()
        {
            _webdriverContext.driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        [Given(@"I search for (.*)")]
        public void GivenISearchForX(string product)
        {
            AutomationPracticeSiteElements.SearchForX(_webdriverContext, product);
        }

        [Then(@"I confirm the search finds (.*) products")]
        public void ThenIConfirmTheSearchReturnsXResults(string expectedNumberOfProducts)
        {
            AutomationPracticeSiteElements.ConfirmNumberOfProductsFound(_webdriverContext, expectedNumberOfProducts);
        }

        [Given(@"I sort the products by (.*)")]
        public void GivenISortTheProductsByX(string sortBy)
        {
            AutomationPracticeSiteElements.SortResultsByX(_webdriverContext, sortBy);
        }

        [When(@"I press the quick view link for the first item")]
        public void GivenIPressTheQuickViewLinkForTheFirstItem()
        {
            AutomationPracticeSiteElements.QuickViewTheFirstItem(_webdriverContext);
        }

        [Then(@"I confirm the selected product is (.*)")]
        public void ThenIConfirmTheSelectedProductIsX(string expectedProductName)
        {
            AutomationPracticeSiteElements.ConfirmProductName(_webdriverContext, expectedProductName);
        }

        [Given(@"I enter (.*) as the quantity")]
        public void GivenIEnterXAsTheQuantity(string quantityRequired)
        {
            AutomationPracticeSiteElements.EnterXAsTheQuantity(_webdriverContext, quantityRequired);
        }

        [Given(@"I set the size to (.*)")]
        public void GivenISetTheSizeToM(string requiredSize)
        {
            AutomationPracticeSiteElements.SetTheSizeToX(_webdriverContext, requiredSize);
        }

        [Given(@"I select the colour (.*)")]
        public void GivenISelectTheColourGreen(string colour)
        {
            AutomationPracticeSiteElements.SelectTheXColour(_webdriverContext, colour);
        }

        [Then(@"I confirm the selected colour is (.*)")]
        public void ThenIConfirmTheSelectedColourIsGreen(string expectedColour)
        {
            AutomationPracticeSiteElements.ConfirmSelectedColourIsX(_webdriverContext, expectedColour);
        }

        [Then(@"I confirm (.*) has been added to the cart")]
        public void ThenIConfirmXHasBeenAddedToTheCart(string productName)
        {
            AutomationPracticeSiteElements.ConfirmXHasBeenAddedToTheCart(_webdriverContext, productName);
        }

        [Then(@"I confirm the total is (.*)")]
        public void ThenIConfirmTheTotalIsX(string expectedTotalAmount)
        {
            AutomationPracticeSiteElements.ConfirmTotalAmountIsX(_webdriverContext, expectedTotalAmount);
        }
    }
}