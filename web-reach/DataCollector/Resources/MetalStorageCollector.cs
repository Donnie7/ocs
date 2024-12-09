namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class MetalStorageCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<MetalStorageData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[8]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[8]/span/span[1]";

    public async Task<MetalStorageData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}