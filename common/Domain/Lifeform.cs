namespace common.Domain;

using LifeformTypes;

public class Lifeform
{
   public ResidentialSector ResidentialSector { get; set; }
   public BiosphereFarm BiosphereFarm { get; set; }
   public ResearchCentre ResearchCentre { get; set; }
   public AcademyOfScience AcademyOfScience { get; set; }
   public NeuroCalibrationCentre NeuroCalibrationCentre { get; set; }
   public HighEnergySmelting HighEnergySmelting { get; set; }
   public FoodSilo FoodSilo { get; set; }
   public FusionPoweredProduction FusionPoweredProduction { get; set; }
   public Skyscraper Skyscraper { get; set; }
   public BiotechLab BiotechLab { get; set; }
   public Metropolis Metropolis { get; set; }
   public PlanetaryShield PlanetaryShield { get; set; }

   public Lifeform()
   {
      ResidentialSector = new ResidentialSector();
      BiosphereFarm = new BiosphereFarm();
      ResearchCentre = new ResearchCentre();
      AcademyOfScience = new AcademyOfScience();
      NeuroCalibrationCentre = new NeuroCalibrationCentre();
      HighEnergySmelting = new HighEnergySmelting();
      FoodSilo = new FoodSilo();
      FusionPoweredProduction = new FusionPoweredProduction();
      Skyscraper = new Skyscraper();
      BiotechLab = new BiotechLab();
      Metropolis = new Metropolis();
      PlanetaryShield = new PlanetaryShield();
   }
}