using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using static Rchoffardet.Benchmarks.ExceptionPerformance.ExceptionHelper;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

[HardwareCounters(BenchmarkDotNet.Diagnosers.HardwareCounter.Timer)]
[ShortRunJob]
public class ExceptionCpuContentionBenchmark
{
    public List<int> items = Enumerable.Range(0, 1000).ToList();

    [Params(1, 2, 4, 8)]
    public int DegreeOfParallelism;
    private IEnumerable<Func<Task>> throwingTasks;
    private IEnumerable<Func<Task>> returningTasks;

    [GlobalSetup]
    public void Setup()
    {
        throwingTasks = Enumerable.Repeat(
            async() => {
                for (int i = 0; i < 1000/DegreeOfParallelism; i++)
                {
                    try
                    {
                        ThrowIn10Calls();
                    }
                    catch (Exception exception)
                    {
                        var stackTrace = exception.StackTrace;
                    }
                }
                await Task.Yield();
            },
            DegreeOfParallelism);

        returningTasks = Enumerable.Repeat(
            async() => {
                await Task.Yield();
                for (int i = 0; i < 1000/DegreeOfParallelism; i++)
                {
                    ReturnIn10Calls();
                }
                await Task.Yield();
            },
            DegreeOfParallelism);
    }

    [Benchmark]
    public async Task Throw()
    {
        await Task.WhenAll(throwingTasks.Select(t => t.Invoke()));
    }

    [Benchmark]
    public async Task Return()
    {
        await Task.WhenAll(returningTasks.Select(t => t.Invoke()));
    }

    
}