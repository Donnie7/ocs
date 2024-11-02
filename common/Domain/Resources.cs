namespace common.Domain;

using ResourceTypes;

public class Resources
{
    public MetalMine MetalMine { get; set; }
    public CrystalMine CrystalMine { get; set; }
    public DeutheriumSynthesizer DeutheriumSynthesizer { get; set; }
    public SolarPlant SolarPlant { get; set; }
    public FusionReactor FusionReactor { get; set; }
    public MetalStorage MetalStorage { get; set; }
    public CrystalStorage CrystalStorage { get; set; }
    public DeuteriumTank DeuteriumTank { get; set; }
    // SolarSatellietes and Crawlers are not here to avoid desync data
    // I only use the ones in Shipyard
    
    public Resources()
    {
        MetalMine = new MetalMine();
        CrystalMine = new CrystalMine();
        DeutheriumSynthesizer = new DeutheriumSynthesizer();
        SolarPlant = new SolarPlant();
        FusionReactor = new FusionReactor();
        MetalStorage = new MetalStorage();
        CrystalStorage = new CrystalStorage();
        DeuteriumTank = new DeuteriumTank();
    }
}