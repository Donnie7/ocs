namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class MetalMineCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<MetalMineData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[1]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[1]/span/span[1]";
    
    public async Task<MetalMineData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}