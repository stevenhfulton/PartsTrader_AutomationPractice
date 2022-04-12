namespace PartsTrader_AutomationPractice.StepDefinitions
{
    [Binding]
    public sealed class SharedSteps
    {
        private readonly WebDriverContext _webdriverContext;

        public SharedSteps(WebDriverContext webdriverContext)
        {
            this._webdriverContext = webdriverContext;
        }

        [Given(@"I save a screenshot")]
        public void GivenISaveAScreenshot()
        {
            SharedElements.SaveAScreenshot(_webdriverContext);
        }

        [Given(@"I press the (.*) button")]
        public void GivenIPressTheAddToCartButton(string buttonText)
        {
            SharedElements.IPressTheXButton(_webdriverContext, buttonText);
        }

        [Given(@"I navigate to the (.*) page")]
        public void GivenINavigateToTheContactUsPage(string linkText)
        {
            SharedElements.IPressTheXLink(_webdriverContext, linkText);
        }

        [Then(@"I confirm the page title is (.*)")]
        public void ThenIConfirmThePageTitleIsX(string expectedTitle)
        {
            SharedElements.ConfirmPageTitleIsX(_webdriverContext, expectedTitle);
        }
    }
}
