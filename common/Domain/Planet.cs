namespace common.Domain;

using ShipyardTypes;

public class Planet
{
   public string Name { get; set; }
   public Coordinates Coordinates { get; set; }
   
   public int MetalValue { get; set; }
   public int CrystalValue { get; set; }
   public int DeuteriumValue { get; set; }
   public int EnergyValue { get; set; }
   public int PopulationValue { get; set; }
   public int FoodValue { get; set; }
   
   public Resources Resources { get; set; }
   public Lifeform Lifeform { get; set; }
   public Facilities Facilities { get; set; }
   public Research Research { get; set; }
   public Shipyard Shipyard { get; set; }
   public Defense Defense { get; set; }

   public Planet(string name, Coordinates coordinates)
   {
      Name = name;
      Coordinates = coordinates;
      Resources = new Resources();
      Lifeform = new Lifeform();
      Facilities = new Facilities();
      Research = new Research();
      Shipyard = new Shipyard();
      Defense = new Defense();
   }
}