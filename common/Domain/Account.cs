namespace common.Domain;

public class Account
{
   public IList<Planet> Planets { get; set; } = new List<Planet>();

   public Planet GetOrCreatePlanet(string planetName, Coordinates coordinates)
   {
      if (Planets.FirstOrDefault(x => x.Name == planetName) is not null)
      {
         return Planets.Single(x => x.Name == planetName);
      }
      var newPlanet = new Planet(planetName, coordinates);
      Planets.Add(newPlanet);
      return newPlanet;
   }
}