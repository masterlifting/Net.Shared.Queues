﻿using static Net.Shared.Queues.Constants.Enums.RabbitMq;

namespace Net.Shared.Queues.Domain.RabbitMq;

public sealed class RabbitMqExchange
{
    public ExchangeTypes Type { get; set; }
    public ExchangeNames Name { get; set; }
    public bool IsDurable { get; set; }
    public bool IsAutoDelete { get; set; }
    public IDictionary<string, object>? Arguments { get; set; }
}