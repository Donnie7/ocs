namespace ghost.Kafka.Consumer;

using common.Kafka.Commands;
using common.Kafka.Commands.Browser;
using common.Kafka.Commands.Navigation;
using Interfaces;
using MediatR;
using web_reach.Interfaces;

public class MessageProcessor : IMessageProcessor
{
    private readonly IOgameCommands ogameCommands;
    private readonly INavigationCommands navigationCommands;
    private readonly IMediator mediator;

    public MessageProcessor(
        IOgameCommands ogameCommands,
        INavigationCommands navigationCommands,
        IMediator mediator)
    {
        this.ogameCommands = ogameCommands;
        this.navigationCommands = navigationCommands;
        this.mediator = mediator;
    }

    public async Task Process(ICommand command)
    {
        switch (command)
        {
            case OpenOGameCommand:
                await ogameCommands.OpenOgame();
                break;
            case LoginCommand:
                await ogameCommands.Login();
                break;
            case CloseOGameCommand:
                await ogameCommands.CloseOGame();
                break;
            case OverviewCommand:
                await navigationCommands.Overview();
                break;
            case ResourcesCommand:
                await mediator.Send(command);
                // mediator is working
                // replace all commands by mediator and probably remove the processor. i think it's no longer needed
                await navigationCommands.Resources();
                break;
            case LifeformCommand:
                await navigationCommands.Lifeform();
                break;
            case FacilitiesCommand:
                await navigationCommands.Facilities();
                break;
            case MerchantCommand:
                await navigationCommands.Merchant();
                break;
            case ResearchCommand:
                await navigationCommands.Research();
                break;
            case ShipyardCommand:
                await navigationCommands.Shipyard();
                break;
            case DefenseCommand:
                await navigationCommands.Defense();
                break;
            case FleetCommand:
                await navigationCommands.Fleet();
                break;
            case GalaxyCommand:
                await navigationCommands.Galaxy();
                break;
            case EmpireCommand:
                await navigationCommands.Empire();
                break;
            case AllianceCommand:
                await navigationCommands.Alliance();
                break;
            default:
                await Task.CompletedTask;
                break;
        }
    }
}