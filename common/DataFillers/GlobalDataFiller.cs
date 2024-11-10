namespace common.DataFillers;

using Domain;
using Kafka.DataMessages;

public class GlobalDataFiller
{
    public static void UpdateAccount(Account account, GlobalData data)
    {
        var collectedPlanet = account.GetOrCreatePlanet(
            data.PlanetName, data.Coordinates);
        collectedPlanet.MetalValue = data.Metal;
        collectedPlanet.CrystalValue = data.Crystal;
        collectedPlanet.DeuteriumValue = data.Deuterium;
        collectedPlanet.EnergyValue = data.Energy;
        collectedPlanet.PopulationValue = data.Population;
        collectedPlanet.FoodValue = data.Food;
    }
}