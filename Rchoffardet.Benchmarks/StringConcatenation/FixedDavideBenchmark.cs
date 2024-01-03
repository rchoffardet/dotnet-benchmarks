using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Rchoffardet.Benchmarks.StringConcatenation;


[MemoryDiagnoser]
[ShortRunJob]
public class FixedDavideBenchmark
{
    private const string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private string[] items = Array.Empty<string>();
    private IEnumerable<string> enumerableItems = Array.Empty<string>();

    [Params(5,10,100,1000)]
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

        enumerableItems = items;
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
    public void StringConcatArray()
    {
        var value = string.Concat(items);
    }

    [Benchmark]
    public void StringConcatEnumerable()
    {
        var value = string.Concat(enumerableItems);
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
