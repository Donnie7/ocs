namespace common.Kafka.Commands.Navigation;

using MediatR;
using MessagePack;

[MessagePackObject]
public class OverviewCommand : ICommand, IRequest;