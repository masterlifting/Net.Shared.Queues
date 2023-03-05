﻿namespace Net.Shared.Queues.Abstractions.Core.WorkQueue;

/// <summary>
///  Asynchronously processing functions in the concurrent queue
/// </summary>
/// <remarks>Disposable</remarks>
public interface IWorkQueue : IDisposable
{
    Task Process(Func<Task> func);
    Task Process(Func<Task>[] funcs);
}
