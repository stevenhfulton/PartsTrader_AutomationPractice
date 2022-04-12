using OpenQA.Selenium.Chrome;

namespace PartsTrader_AutomationPractice
{
    public sealed class WebDriverContext
    {
        public ChromeDriver driver;

        public WebDriverContext()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headed");
            driver = new ChromeDriver(options);  
        }
    }
}