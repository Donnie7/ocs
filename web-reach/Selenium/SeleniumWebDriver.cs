namespace web_reach.Selenium;

using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class SeleniumWebDriver : ISeleniumWebDriver
{
    private WebDriverWait Wait { get; set; }
    private ChromeDriver Driver { get; set; }

    public ChromeDriver InitDriver()
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

    public Task GoToURL(string url)
    {
        Driver.Url = url;
        return Task.CompletedTask;
    }

    public Task ClickButton(string buttonXPath)
    {
        Driver.FindElement(By.XPath(buttonXPath)).Click();
        return Task.CompletedTask;
    }

    public Task SendKeys(string inputXPath, string keys)
    {
       Driver.FindElement(By.XPath(inputXPath)).SendKeys(keys);
        return Task.CompletedTask;
    }

    public Task CloseOGame()
    {
        Driver.Close();
        return Task.CompletedTask;
    }

    public Task<string> ReadText(string valueXPath)
    {
        return Task.FromResult(Driver.FindElement(By.XPath(valueXPath)).Text);
    }

    public Task<int> ReadInteger(string valueXPath)
    {
        var valueText = Driver.FindElement(By.XPath(valueXPath)).Text;
        return Task.FromResult(int.Parse(valueText, NumberStyles.AllowThousands, CultureInfo.InvariantCulture));
    }

    public Task WaitUntilAvailable(By by)
    {
        for (var i = 0; i < 10; i++)
        {
            try
            {
                Wait.Until(driver =>
                {
                    var element = driver.FindElement(by);
                    return element.Displayed && element.Enabled;
                });
                return Task.CompletedTask;
            }
            catch (StaleElementReferenceException)
            {
                Task.Delay(500).Wait();
            }
        }

        throw new Exception("Unable to find element. Timeout expired");
    }

    public Task SwitchToWindow(string title)
    {
        foreach (var handle in Driver.WindowHandles)
        {
            Driver.SwitchTo().Window(handle);
            if (Driver.Title == title)
            {
                return Task.CompletedTask;
            }
        }

        throw new ArgumentException($"Unable to find window with title: '{title}'");
    }
}