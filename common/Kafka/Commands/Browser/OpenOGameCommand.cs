namespace common.Kafka.Commands.Browser;

using MediatR;
using MessagePack;

[MessagePackObject]
public class OpenOGameCommand : ICommand, IRequest;