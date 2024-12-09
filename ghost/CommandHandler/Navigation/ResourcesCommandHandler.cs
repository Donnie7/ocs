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
    private readonly DeuteriumSynthesizerCollector deuteriumSynthesizerCollector;
    private readonly SolarPlantCollector solarPlantCollector;
    private readonly FusionReactorCollector fusionReactorCollector;
    private readonly MetalStorageCollector metalStorageCollector;
    private readonly CrystalStorageCollector crystalStorageCollector;
    private readonly DeuteriumTankCollector deuteriumTankCollector;
    private readonly DataCollectorProducer dataCollectorProducer;

    public ResourcesCommandHandler(
        INavigationCommands navigationCommands,
        Account account,
        MetalMineCollector metalMineCollector,
        CrystalMineCollector crystalMineCollector,
        DeuteriumSynthesizerCollector deuteriumSynthesizerCollector,
        SolarPlantCollector solarPlantCollector,
        FusionReactorCollector fusionReactorCollector,
        MetalStorageCollector metalStorageCollector,
        CrystalStorageCollector crystalStorageCollector,
        DeuteriumTankCollector deuteriumTankCollector,
        DataCollectorProducer dataCollectorProducer)
    {
        this.navigationCommands = navigationCommands;
        this.account = account;
        this.metalMineCollector = metalMineCollector;
        this.crystalMineCollector = crystalMineCollector;
        this.deuteriumSynthesizerCollector = deuteriumSynthesizerCollector;
        this.solarPlantCollector = solarPlantCollector;
        this.fusionReactorCollector = fusionReactorCollector;
        this.metalStorageCollector = metalStorageCollector;
        this.crystalStorageCollector = crystalStorageCollector;
        this.dataCollectorProducer = dataCollectorProducer;
    }
    
    public async Task Handle(ResourcesCommand request, CancellationToken cancellationToken)
    {
        await navigationCommands.Resources();
        await CollectMetalMineData();
        await CollectCrystalMineData();
        await CollectDeuteriumSynthesizerData();
        await CollectSolarPlantData();
        await CollectFusionReactorData();
        await CollectMetalStorageData();
        await CollectCrystalStorageData();
        await CollectDeuteriumTankData();
    }

    private async Task CollectCrystalMineData()
    {
        var crystalMineData = await crystalMineCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, crystalMineData);
        await dataCollectorProducer.SendCollectedData(crystalMineData);
    }

    private async Task CollectMetalMineData()
    {
        var metalMineData = await metalMineCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, metalMineData);
        await dataCollectorProducer.SendCollectedData(metalMineData);
    }
    
    private async Task CollectDeuteriumSynthesizerData()
    {
        var deuteriumSynthesizerData = await deuteriumSynthesizerCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, deuteriumSynthesizerData);
        await dataCollectorProducer.SendCollectedData(deuteriumSynthesizerData);
    }
    
    private async Task CollectSolarPlantData()
    {
        var solarPlantData = await solarPlantCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, solarPlantData);
        await dataCollectorProducer.SendCollectedData(solarPlantData);
    }
    
    private async Task CollectFusionReactorData()
    {
        var fusionReactorData = await fusionReactorCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, fusionReactorData);
        await dataCollectorProducer.SendCollectedData(fusionReactorData);
    }
    
    private async Task CollectMetalStorageData()
    {
        var metalStorageData = await metalStorageCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, metalStorageData);
        await dataCollectorProducer.SendCollectedData(metalStorageData);
    }
    
    private async Task CollectCrystalStorageData()
    {
        var crystalStorageData = await crystalStorageCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, crystalStorageData);
        await dataCollectorProducer.SendCollectedData(crystalStorageData);
    }
    
    private async Task CollectDeuteriumTankData()
    {
        var deuteriumTankData = await deuteriumTankCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, deuteriumTankData);
        await dataCollectorProducer.SendCollectedData(deuteriumTankData);
    }
}