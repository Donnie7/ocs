namespace common.Domain;

using ShipyardTypes;

public class Planet
{
   public string Name { get; set; }
   public Coordinates Coordinates { get; set; }
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