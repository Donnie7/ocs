﻿namespace common.Kafka.Commands.Navigation;

using MediatR;
using MessagePack;

[MessagePackObject]
public class ResourcesCommand : ICommand, IRequest;