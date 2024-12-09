namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class SolarPlantCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<SolarPlantData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[4]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[4]/span/span[1]";

    public async Task<SolarPlantData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}