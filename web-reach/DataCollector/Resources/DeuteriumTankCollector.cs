namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class DeuteriumTankCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<DeuteriumTankData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[10]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[10]/span/span[1]";

    public async Task<DeuteriumTankData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}