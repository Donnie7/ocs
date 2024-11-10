namespace ghost.CommandHandler.Navigation;

using common.DataFillers;
using common.Domain;
using common.Kafka.Commands.Navigation;
using Kafka.Producer;
using MediatR;
using web_reach.DataCollector.Global;
using web_reach.Interfaces;

public class OverviewCommandHandler : IRequestHandler<OverviewCommand>
{
    private readonly INavigationCommands navigateTo;
    private readonly Account account;
    private readonly GlobalContextCollector globalCollector;
    private readonly DataCollectorProducer dataCollector;

    public OverviewCommandHandler(
        INavigationCommands navigateTo,
        Account account,
        GlobalContextCollector globalCollector,
        DataCollectorProducer dataCollector)
    {
        this.navigateTo = navigateTo;
        this.account = account;
        this.globalCollector = globalCollector;
        this.dataCollector = dataCollector;
    }
    
    public async Task Handle(OverviewCommand request, CancellationToken cancellationToken)
    {
        await navigateTo.Overview();
        var overviewData = await globalCollector.Collect();
        GlobalDataFiller.UpdateAccount(account, overviewData);
        await dataCollector.SendCollectedData(overviewData);
    }
}