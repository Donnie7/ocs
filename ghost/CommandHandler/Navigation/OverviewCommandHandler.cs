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
    private readonly INavigationCommands navigationCommands;
    private readonly Account account;
    private readonly GlobalContextCollector globalContextCollector;
    private readonly DataCollectorProducer dataCollectorProducer;

    public OverviewCommandHandler(
        INavigationCommands navigationCommands,
        Account account,
        GlobalContextCollector globalContextCollector,
        DataCollectorProducer dataCollectorProducer)
    {
        this.navigationCommands = navigationCommands;
        this.account = account;
        this.globalContextCollector = globalContextCollector;
        this.dataCollectorProducer = dataCollectorProducer;
    }
    
    public async Task Handle(OverviewCommand request, CancellationToken cancellationToken)
    {
        await navigationCommands.Overview();
        var data = await globalContextCollector.Collect();
        GlobalDataFiller.PopulateAccount(account, data);
        await dataCollectorProducer.SendOverview(data);
    }
}