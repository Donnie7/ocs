namespace common.Commands;

using Browser;
using Navigation;

[MessagePack.Union(0, typeof(OpenOGameCommand))]
[MessagePack.Union(1, typeof(LoginCommand))]
[MessagePack.Union(2, typeof(CloseOGameCommand))]
[MessagePack.Union(3, typeof(AllianceCommand))]
[MessagePack.Union(4, typeof(DefenseCommand))]
[MessagePack.Union(5, typeof(EmpireCommand))]
[MessagePack.Union(6, typeof(FacilitiesCommand))]
[MessagePack.Union(7, typeof(FleetCommand))]
[MessagePack.Union(8, typeof(GalaxyCommand))]
[MessagePack.Union(9, typeof(LifeformCommand))]
[MessagePack.Union(10, typeof(MerchantCommand))]
[MessagePack.Union(11, typeof(OverviewCommand))]
[MessagePack.Union(12, typeof(ResearchCommand))]
[MessagePack.Union(13, typeof(ResourcesCommand))]
[MessagePack.Union(14, typeof(ShipyardCommand))]
public interface ICommand;