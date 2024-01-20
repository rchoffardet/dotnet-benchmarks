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
public class StackDepthPenaltyBenchmark
{
    [BenchmarkCategory("001 level")]
    [Benchmark]
    public string ThrowIn1Call()
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

    [BenchmarkCategory("002 levels")]
    [Benchmark]
    public string ThrowIn2Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn2Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("004 levels")]
    [Benchmark]
    public string ThrowIn4Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn4Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("008 levels")]
    [Benchmark]
    public string ThrowIn8Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn8Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("016 levels")]
    [Benchmark]
    public string ThrowIn16Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn16Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("032 levels")]
    [Benchmark]
    public string ThrowIn32Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn32Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("064 levels")]
    [Benchmark]
    public string ThrowIn64Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn64Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("128 levels")]
    [Benchmark]
    public string ThrowIn128Calls()
    {
        try
        {
            return ExceptionHelper.ThrowIn128Calls();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [BenchmarkCategory("001 level")]
    [Benchmark]
    public string ThrowIn1CallWithStackTrace()
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

    [BenchmarkCategory("002 levels")]
    [Benchmark]
    public string ThrowIn2CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn2Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("004 levels")]
    [Benchmark]
    public string ThrowIn4CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn4Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("008 levels")]
    [Benchmark]
    public string ThrowIn8CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn8Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("016 levels")]
    [Benchmark]
    public string ThrowIn16CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn16Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("032 levels")]
    [Benchmark]
    public string ThrowIn32CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn32Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("064 levels")]
    [Benchmark]
    public string ThrowIn64CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn64Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

    [BenchmarkCategory("128 levels")]
    [Benchmark]
    public string ThrowIn128CallsWithStackTrace()
    {
        try
        {
            return ExceptionHelper.ThrowIn128Calls();
        }
        catch (Exception ex)
        {
            return ex.StackTrace;
        }
    }

}