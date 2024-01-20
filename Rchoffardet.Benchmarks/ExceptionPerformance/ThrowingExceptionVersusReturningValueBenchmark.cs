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
public class ThrowingExceptionVersusReturningValueBenchmark
{
    [Benchmark]
    public string ReturningValue()
    {
        return ExceptionHelper.ReturnIn1Call();
    }

    [Benchmark]
    public string Throwing()
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
}