﻿using Net.Shared.Queues.Abstractions.Settings;

using Shared.Background.Settings.Models;

namespace Net.Shared.Queues.Settings.RabbitMq;

public sealed class RabbitMqConsumerSettings : IMqConsumerSettings
{
    public string Queue { get; set; } = null!;
    public int Limit { get; set; }
    public TaskSchedulerSettings Scheduler { get; set; } = new();

    public bool IsExclusiveQueue { get; set; }
    public bool IsAutoAck { get; set; }
    public string? ConsumerTag { get; set; }
    public bool IsNoLocal { get; set; }

    public IDictionary<string, object>? Arguments { get; set; }
}