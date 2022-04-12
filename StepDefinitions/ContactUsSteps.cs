namespace PartsTrader_AutomationPractice.StepDefinitions
{
    [Binding]
    public sealed class ContactUsSteps
    {
        private readonly WebDriverContext _webdriverContext;

        public ContactUsSteps(WebDriverContext webdriverContext)
        {
            this._webdriverContext = webdriverContext;
        }

        [Given(@"I choose (.*) as the subject heading")]
        public void GivenIChooseXAsTheSubjectHeading(string subjectHeading)
        {
            ContactUsElements.SelectXAsTheHeading(_webdriverContext, subjectHeading);
        }

        [Given(@"I enter (.*) as the email address")]
        public void GivenIEnterXAsTheEmailAddress(string emailAddress)
        {
            ContactUsElements.EnterXAsTheEmailAddress(_webdriverContext, emailAddress);
        }

        [Given(@"I enter (.*) as the order number")]
        public void GivenIEnterXAsMyOrderNumber(string orderNumber)
        {
            ContactUsElements.EnterXAsTheOrderNumber(_webdriverContext, orderNumber);
        }

        [Given(@"I enter (.*) as the message")]
        public void GivenIEnterXxxAsTheMessage(string message)
        {
            ContactUsElements.EnterXAsTheMessage(_webdriverContext, message);
        }

        [Then(@"I confirm the message has been sent")]
        public void ThenIConfirmTheMessageHasBeenSent()
        {
            ContactUsElements.ConfirmConfirmationMessageIsDisplayed(_webdriverContext);
        }
    }
}
