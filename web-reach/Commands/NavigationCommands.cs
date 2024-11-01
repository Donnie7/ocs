namespace web_reach.Commands;

using Interfaces;
using Selenium;

public class NavigationCommands(ISeleniumWebDriver driver) : SeleniumCommand(driver), INavigationCommands
{
    private const string OverviewButton = "//*[@id=\"menuTable\"]/li[1]/a/span";
    private const string ResourcesButton = "//*[@id=\"menuTable\"]/li[2]/a/span";
    private const string LifeformButton = "//*[@id=\"menuTable\"]/li[3]/a/span";
    private const string FacilitiesButton = "//*[@id=\"menuTable\"]/li[4]/a/span";
    private const string MerchantButton = "//*[@id=\"menuTable\"]/li[5]/a/span";
    private const string ResearchButton = "//*[@id=\"menuTable\"]/li[6]/a/span";
    private const string ShipyardButton = "//*[@id=\"menuTable\"]/li[7]/a/span";
    private const string DefenseButton = "//*[@id=\"menuTable\"]/li[8]/a/span";
    private const string FleetButton = "//*[@id=\"menuTable\"]/li[9]/a/span";
    private const string GalaxyButton = "//*[@id=\"menuTable\"]/li[10]/a/span";
    private const string EmpireButton = "//*[@id=\"menuTable\"]/li[11]/a/span";
    private const string AllianceButton = "//*[@id=\"menuTable\"]/li[12]/a/span";
    
    public Task Alliance()
    {
        Driver.ClickButton(AllianceButton);
        return Task.CompletedTask;
    }

    public Task Defense()
    {
        Driver.ClickButton(DefenseButton);
        return Task.CompletedTask;
    }

    public Task Empire()
    {
        Driver.ClickButton(EmpireButton);
        return Task.CompletedTask;
    }

    public Task Facilities()
    {
        Driver.ClickButton(FacilitiesButton);
        return Task.CompletedTask;
    }

    public Task Fleet()
    {
        Driver.ClickButton(FleetButton);
        return Task.CompletedTask;
    }

    public Task Galaxy()
    {
        Driver.ClickButton(GalaxyButton);
        return Task.CompletedTask;
    }

    public Task Lifeform()
    {
        Driver.ClickButton(LifeformButton);
        return Task.CompletedTask;
    }

    public Task Merchant()
    {
        Driver.ClickButton(MerchantButton);
        return Task.CompletedTask;
    }

    public Task Overview()
    {
        Driver.ClickButton(OverviewButton);
        return Task.CompletedTask;
    }

    public Task Research()
    {
        Driver.ClickButton(ResearchButton);
        return Task.CompletedTask;
    }

    public Task Resources()
    {
        Driver.ClickButton(ResourcesButton);
        return Task.CompletedTask;
    }

    public Task Shipyard()
    {
        Driver.ClickButton(ShipyardButton);
        return Task.CompletedTask;
    }
}