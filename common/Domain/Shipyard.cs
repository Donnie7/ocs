namespace common.Domain;

using ShipyardTypes;

public class Shipyard
{
   public LightFighter LightFighter { get; set; }
   public HeavyFighter HeavyFighter { get; set; }
   public Cruiser Cruiser { get; set; }
   public Battleship Battleship { get; set; }
   public Battlecruiser Battlecruiser { get; set; }
   public Bomber Bomber { get; set; }
   public Destroyer Destroyer { get; set; }
   public Deathstar Deathstar { get; set; }
   public Reaper Reaper { get; set; }
   public Pathfinder Pathfinder { get; set; }
   public SmallCargo SmallCargo { get; set; }
   public LargeCargo LargeCargo { get; set; }
   public ColonyShip ColonyShip { get; set; }
   public Recycler Recycler { get; set; }
   public EspionageProbe EspionageProbe { get; set; }
   public SolarSatellite SolarSatellite { get; set; }
   public Crawler Crawler { get; set; }

   public Shipyard()
   {
      LightFighter = new LightFighter();
      HeavyFighter = new HeavyFighter();
      Cruiser = new Cruiser();
      Battleship = new Battleship();
      Battlecruiser = new Battlecruiser();
      Bomber = new Bomber();
      Destroyer = new Destroyer();
      Deathstar = new Deathstar();
      Reaper = new Reaper();
      Pathfinder = new Pathfinder();
      SmallCargo = new SmallCargo();
      LargeCargo = new LargeCargo();
      ColonyShip = new ColonyShip();
      Recycler = new Recycler();
      EspionageProbe = new EspionageProbe();
      SolarSatellite = new SolarSatellite();
      Crawler = new Crawler();
   }
}