﻿namespace common.Kafka.Commands.Navigation;

using MediatR;
using MessagePack;

[MessagePackObject]
public class FleetCommand : ICommand, IRequest;