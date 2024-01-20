using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

[ShortRunJob]
[MemoryDiagnoser]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
public class StackTracePenaltyBenchmark
{
    [Benchmark]
    public string GettingTheMessage()
    {
        try
        {
            return ExceptionHelper.ThrowIn1Call();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [Benchmark]
    public string GettingTheStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn1Call();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }
}