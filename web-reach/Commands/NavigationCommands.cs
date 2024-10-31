namespace web_reach.Commands;

using Interfaces;
using Selenium;

public class NavigationCommands(ISeleniumWebDriver driver) : SeleniumCommand(driver), INavigationCommands
{
    private const string AllianceButton = "//*[@id=\"menuTable\"]/li[12]/a/span";
    private const string OverviewButton = "//*[@id=\"menuTable\"]/li[1]/a/span";
    
    public Task Alliance()
    {
        Driver.ClickButton(AllianceButton);
        return Task.CompletedTask;
    }

    public Task Defense()
    {
        throw new NotImplementedException();
    }

    public Task Empire()
    {
        throw new NotImplementedException();
    }

    public Task Facilities()
    {
        throw new NotImplementedException();
    }

    public Task Fleet()
    {
        throw new NotImplementedException();
    }

    public Task Galaxy()
    {
        throw new NotImplementedException();
    }

    public Task Lifeform()
    {
        throw new NotImplementedException();
    }

    public Task Merchant()
    {
        throw new NotImplementedException();
    }

    public Task Overview()
    {
        Driver.ClickButton(OverviewButton);
        return Task.CompletedTask;
    }

    public Task Research()
    {
        throw new NotImplementedException();
    }

    public Task Resources()
    {
        throw new NotImplementedException();
    }

    public Task Shipyard()
    {
        throw new NotImplementedException();
    }
}