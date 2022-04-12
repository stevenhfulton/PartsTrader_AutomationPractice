namespace PartsTrader_AutomationPractice.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly WebDriverContext _webdriverContext;

        public Hooks(WebDriverContext webdriverContext, ScenarioContext scenarioContext)
        {
            this._webdriverContext = webdriverContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _webdriverContext.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webdriverContext.driver.Quit();
        }
    }
}