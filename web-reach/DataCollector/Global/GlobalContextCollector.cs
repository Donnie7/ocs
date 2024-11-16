namespace web_reach.DataCollector.Global;

using Commands;
using common.Domain;
using common.Kafka.DataMessages;
using Selenium;

public class GlobalContextCollector(ISeleniumWebDriver driver) : SeleniumCommand(driver), IDataCollector<GlobalData>
{
   private const string PlanetNameXPath = "//*[@id=\"planet-33664279\"]/a/span[1]";
   private const string CoordinatesXPath = "//*[@id=\"planet-33664279\"]/a/span[2]";
   private const string MetalXPath = "//*[@id=\"resources_metal\"]";
   private const string CrystalXPath = "//*[@id=\"resources_crystal\"]";
   private const string DeuteriumXPath = "//*[@id=\"resources_deuterium\"]";
   private const string EnergyXPath = "//*[@id=\"resources_energy\"]";
   private const string PopulationXPath = "//*[@id=\"resources_population\"]";
   private const string FoodXPath = "//*[@id=\"resources_food\"]";
   

   public async Task<GlobalData> Collect() =>
      new()
      {
         PlanetName = await Driver.ReadText(PlanetNameXPath),
         Coordinates = new Coordinates(await Driver.ReadText(CoordinatesXPath)),
         Metal = await Driver.ReadInteger(MetalXPath),
         Crystal = await Driver.ReadInteger(CrystalXPath),
         Deuterium = await Driver.ReadInteger(DeuteriumXPath),
         Energy = await Driver.ReadInteger(EnergyXPath),
         Population = await Driver.ReadInteger(PopulationXPath),
         Food = await Driver.ReadInteger(FoodXPath)
      };
}