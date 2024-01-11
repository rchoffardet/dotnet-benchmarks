using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using static Rchoffardet.Benchmarks.ExceptionPerformance.ExceptionHelper;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

[MemoryDiagnoser]
[ShortRunJob]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
public class ExceptionPerformanceBenchmark
{
    [BenchmarkCategory("1- Shallow")]
    [Benchmark(Baseline = true)]
    public string ShallowDepthCall()
    {
        return ReturnIn1Call();
    }

    [BenchmarkCategory("2- Medium")]
    [Benchmark(Baseline = true)]
    public string MediumDepthCall()
    {
        return ReturnIn10Calls();
    }

    [BenchmarkCategory("3- Deep")]
    [Benchmark(Baseline = true)]
    public string DeepDepthCall()
    {
        return ReturnIn20Calls();
    }

    [BenchmarkCategory("1- Shallow")]
    [Benchmark]
    public string ShallowDepthThrow()
    {
        try
        {
            return ThrowIn1Call();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("2- Medium")]
    [Benchmark]
    public string MediumDepthThrow()
    {
        try
        {
            return ThrowIn10Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("3- Deep")]
    [Benchmark]
    public string DeepDepthThrow()
    {
        try
        {
            return ThrowIn20Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("1- Shallow")]
    [Benchmark]
    public string ShallowDepthThrowWithStackTrace()
    {
        try
        {
            return ThrowIn1Call();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("2- Medium")]
    [Benchmark]
    public string MediumDepthThrowWithStackTrace()
    {
        try
        {
            return ThrowIn10Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("3- Deep")]
    [Benchmark]
    public string DeepDepthThrowWithStackTrace()
    {
        try
        {
            return ThrowIn20Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }
}