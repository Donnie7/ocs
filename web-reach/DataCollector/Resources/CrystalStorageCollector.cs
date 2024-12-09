namespace web_reach.DataCollector.Resources;

using Commands;
using common.Kafka.DataMessages.Resources;
using Selenium;

public class CrystalStorageCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<CrystalStorageData>
{
    private const string CurrentLevelXPath = "//*[@id=\"producers\"]/li[9]/span/span[1]/span[1]";
    private const string IsUpgradingXPath = "//*[@id=\"producers\"]/li[9]/span/span[1]";

    public async Task<CrystalStorageData> Collect() =>
        new()
        {
            Level = await Driver.ReadInteger(CurrentLevelXPath),
            IsUpgrading = await Driver.IsPresent(IsUpgradingXPath),
        };
}