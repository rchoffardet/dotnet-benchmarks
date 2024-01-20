using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

[ShortRunJob]
[MemoryDiagnoser]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
public class ExceptionCatchingEarlyBenchmark
{
    [Benchmark]
    public string CatchEarly()
    {
        return ExceptionHelper.Catch1CallAndReturnIn20();
    }

    [Benchmark]
    public string CatchMedium()
    {
        return ExceptionHelper.Catch10CallAndReturnIn10();
    }
    
    [Benchmark]
    public string CatchLate()
    {
        return ExceptionHelper.Catch20CallAndReturnIn1();
    }
}