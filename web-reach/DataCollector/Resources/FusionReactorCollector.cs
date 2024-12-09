namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class FusionReactorCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<FusionReactorData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[5]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[5]/span/span[1]";

    public async Task<FusionReactorData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}