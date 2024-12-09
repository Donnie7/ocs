namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class DeuteriumSynthesizerCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<DeuteriumSynthesizerData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[3]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[3]/span/span[1]";

    public async Task<DeuteriumSynthesizerData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}