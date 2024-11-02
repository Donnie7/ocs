namespace common.Domain;

using FacilitiesTypes;

public class Facilities
{
    public RoboticsFactory RoboticsFactory { get; set; }
    public Shipyard Shipyard { get; set; }
    public ResearchLab ResearchLab { get; set; }
    public AllianceDepot AllianceDepot { get; set; }
    public MissileSilo MissileSilo { get; set; }
    public NaniteFactory NaniteFactory { get; set; }
    public Terraformer Terraformer { get; set; }
    public SpaceDock SpaceDock { get; set; }

    public Facilities()
    {
        RoboticsFactory = new RoboticsFactory();
        Shipyard = new Shipyard();
        ResearchLab = new ResearchLab();
        AllianceDepot = new AllianceDepot();
        MissileSilo = new MissileSilo();
        NaniteFactory = new NaniteFactory();
        Terraformer = new Terraformer();
        SpaceDock = new SpaceDock();
    }
}