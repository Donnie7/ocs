namespace ghost.Kafka.Consumer;

using common.Kafka.Commands;
using MediatR;

public class MessageProcessor : IMessageProcessor
{
    private readonly IMediator mediator;

    public MessageProcessor(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public async Task Process(ICommand command)
    {
        await mediator.Send(command);
    }
}