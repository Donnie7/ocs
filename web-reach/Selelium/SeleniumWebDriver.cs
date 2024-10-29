namespace web_reach.Selelium;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class SeleniumWebDriver
{
    private WebDriverWait Wait { get; set; }
    protected ChromeDriver Driver { get; set; }

    protected SeleniumWebDriver()
    {
        Driver = InitDriver();
    }

    protected ChromeDriver InitDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        options.AddExcludedArgument("enable-automation");
        options.AddAdditionalOption("useAutomationExtension", false);
        
        Driver = new ChromeDriver(options);
        Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return Driver;
    }

    protected void WaitUntilAvailable(By by)
    {
        for (int i = 0; i < 3; i++)
        {
            try
            {
                Wait.Until(driver =>
                {
                    var element = driver.FindElement(by);
                    return element.Displayed && element.Enabled;
                });
                return;
            }
            catch (StaleElementReferenceException)
            {
                Task.Delay(500).Wait();
            }
        }
    }
    
    protected void SwitchToWindow(string title)
    {
        foreach (var handle in Driver.WindowHandles)
        {
            Driver.SwitchTo().Window(handle);
            if (Driver.Title == title)
            {
                return;
            }
        }

        throw new ArgumentException($"Unable to find window with title: '{title}'");
    }
}