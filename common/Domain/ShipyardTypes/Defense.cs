namespace common.Domain.ShipyardTypes;

using DefenceTypes;

public class Defense
{
    public RocketLauncher RocketLauncher { get; set; }
    public LightLaser LightLaser { get; set; }
    public HeavyLaser HeavyLaser { get; set; }
    public GaussCannon GaussCannon { get; set; }
    public IonCannon IonCannon { get; set; }
    public PlasmaTurret PlasmaTurret { get; set; }
    public SmallShieldDome SmallShieldDome { get; set; }
    public LargeShieldDome LargeShieldDome { get; set; }
    public AntiBallisticMissiles AntiBallisticMissiles { get; set; }
    public InterplanetaryMissiles InterplanetaryMissiles { get; set; }

    public Defense()
    {
        RocketLauncher = new RocketLauncher();
        LightLaser = new LightLaser();
        HeavyLaser = new HeavyLaser();
        GaussCannon = new GaussCannon();
        IonCannon = new IonCannon();
        PlasmaTurret = new PlasmaTurret();
        SmallShieldDome = new SmallShieldDome();
        LargeShieldDome = new LargeShieldDome();
        AntiBallisticMissiles = new AntiBallisticMissiles();
        InterplanetaryMissiles = new InterplanetaryMissiles();
    }
}