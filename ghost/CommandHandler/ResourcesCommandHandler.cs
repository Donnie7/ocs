namespace ghost.CommandHandler;

using common.Kafka.Commands.Navigation;
using MediatR;

public class ResourcesCommandHandler : IRequestHandler<ResourcesCommand>
{
    public Task Handle(ResourcesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}