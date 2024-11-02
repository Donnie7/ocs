namespace common.Domain;

using ResearchTypes;

public class Research
{
   public EnergyTechnology EnergyTechnology { get; set; }
   public LaserTechnology LaserTechnology { get; set; }
   public IonTechnology IonTechnology { get; set; }
   public HyperspaceTechnology HyperspaceTechnology { get; set; }
   public PlasmaTechnology PlasmaTechnology { get; set; }
   public CombustionDrive CombustionDrive { get; set; }
   public ImpulseDrive ImpulseDrive { get; set; }
   public HyperspaceDrive HyperspaceDrive { get; set; }
   public EspionageTechnology EspionageTechnology { get; set; }
   public ComputerTechnology ComputerTechnology { get; set; }
   public Astrophysics Astrophysics { get; set; }
   public IntergalacticResearchNetwork IntergalacticResearchNetwork { get; set; }
   public GravitonTechnology GravitonTechnology { get; set; }
   public WeaponsTechnology WeaponsTechnology { get; set; }
   public ShieldingTechnology ShieldingTechnology { get; set; }
   public ArmourTechnology ArmourTechnology { get; set; }

   public Research()
   {
      EnergyTechnology = new EnergyTechnology();
      LaserTechnology = new LaserTechnology();
      IonTechnology = new IonTechnology();
      HyperspaceTechnology = new HyperspaceTechnology();
      PlasmaTechnology = new PlasmaTechnology();
      CombustionDrive = new CombustionDrive();
      ImpulseDrive = new ImpulseDrive();
      HyperspaceDrive = new HyperspaceDrive();
      EspionageTechnology = new EspionageTechnology();
      ComputerTechnology = new ComputerTechnology();
      Astrophysics = new Astrophysics();
      IntergalacticResearchNetwork = new IntergalacticResearchNetwork();
      GravitonTechnology = new GravitonTechnology();
      WeaponsTechnology = new WeaponsTechnology();
      ShieldingTechnology = new ShieldingTechnology();
      ArmourTechnology = new ArmourTechnology();
   }
}