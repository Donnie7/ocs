namespace ghost.CommandHandler.Navigation;

using common.DataFillers;
using common.Domain;
using common.Kafka.Commands.Navigation;
using Kafka.Producer;
using MediatR;
using web_reach.DataCollector.Resources;
using web_reach.Interfaces;

public class ResourcesCommandHandler : IRequestHandler<ResourcesCommand>
{
    private readonly INavigationCommands navigationCommands;
    private readonly Account account;
    private readonly MetalMineCollector metalMineCollector;
    private readonly CrystalMineCollector crystalMineCollector;
    private readonly DataCollectorProducer dataCollectorProducer;

    public ResourcesCommandHandler(
        INavigationCommands navigationCommands,
        Account account,
        MetalMineCollector metalMineCollector,
        CrystalMineCollector crystalMineCollector,
        DataCollectorProducer dataCollectorProducer)
    {
        this.navigationCommands = navigationCommands;
        this.account = account;
        this.metalMineCollector = metalMineCollector;
        this.crystalMineCollector = crystalMineCollector;
        this.dataCollectorProducer = dataCollectorProducer;
    }
    
    public async Task Handle(ResourcesCommand request, CancellationToken cancellationToken)
    {
        await navigationCommands.Resources();
        await CollectMetalMineData();
        await CollectCrystalMineData();
    }

    private async Task CollectCrystalMineData()
    {
        var crytalMineData = await crystalMineCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, crytalMineData);
        await dataCollectorProducer.SendCollectedData(crytalMineData);
    }

    private async Task CollectMetalMineData()
    {
        var metalMineData = await metalMineCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, metalMineData);
        await dataCollectorProducer.SendCollectedData(metalMineData);
    }
}