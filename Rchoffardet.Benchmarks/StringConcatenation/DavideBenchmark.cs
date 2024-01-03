using System;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Rchoffardet.Benchmarks.StringConcatenation;

[MemoryDiagnoser]
[ShortRunJob]
public class DavideBenchmark
{
    private const string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private string[] items = Array.Empty<string>();

    [Params(5,6,9,10,100,1000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        items = new string[N];
        var random = new Random();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                items[i] += charset[random.Next(0, charset.Length)];
            }
        }
    }

    [Benchmark]
    public void Append()
    {
        var value = "";

        foreach(var item in items)
        {
            value += item;
        }
    }

    [Benchmark]
    public void StringConcat()
    {
        var value = "";

        foreach(var item in items)
        {
            value = string.Concat(value, item);
        }
    }

    [Benchmark]
    public void StringBuilder()
    {
        var sb = new StringBuilder();

        foreach(var item in items)
        {
            sb.Append(item);
        }

        var value = sb.ToString();
    }
}
