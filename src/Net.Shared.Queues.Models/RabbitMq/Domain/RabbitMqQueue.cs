﻿namespace Net.Shared.Queues.Models.RabbitMq.Domain;

public sealed record RabbitMqQueue
{
    public string Name { get; init; } = null!;
    public bool IsDurable { get; init; }
    public bool IsExclusive { get; init; }
    public bool IsAutoDelete { get; init; }
    public IDictionary<string, object>? Arguments { get; init; }
}