namespace web_reach.Commands;

using Selenium;

public class SeleniumCommand
{
    protected ISeleniumWebDriver Driver { get; }

    public SeleniumCommand(ISeleniumWebDriver driver)
    {
        Driver = driver;
    }
}