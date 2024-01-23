using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Spectre.Console;
using Spectre.Console.Rendering;
using static Rchoffardet.Benchmarks.ExceptionPerformance.ExceptionHelper;

namespace Rchoffardet.Benchmarks.ExceptionPerformance;

public class ExceptionCpuContentionStopWatch
{
    public static int[] iterationCounts = [10_000];
    public static IEnumerable<int> threadCounts = Enumerable.Range(1, 32);
    public static int[] nestedLevels = [2];

    public static void Main()
    {
        var table = new Table();
        table.Border(new MarkdownTableBorder());
        //table.AddColumn("Iteration count");
        //table.AddColumn("Nesting count");
        table.AddColumn("Thread count");
        table.AddColumn("Time per exception thrown (ns)");

        foreach(var iterationCount in iterationCounts)
        {
            foreach (var threadCount in threadCounts)
            {
                foreach(var nestedLevel in nestedLevels)
                {
                    Console.WriteLine($"Measuring throwing {iterationCount} exceptions (nested {nestedLevel} times) in {threadCount} threads.");
                    long totalTimeNs = 0;
                    ExecuteConcurrently(() =>
                    {
                        Stopwatch sw = Stopwatch.StartNew();
                        for (int i = 0; i < iterationCount; i++)
                        {
                            try
                            {
                                _ = nestedLevel switch
                                {
                                    1 => ThrowIn1Call(),
                                    2 => ReturnIn1Call(),
                                    20 => ThrowIn20Calls(),
                                    _ => throw new NotImplementedException()
                                };
                            }
                            catch(InvalidOperationException) {}
                        }
                        sw.Stop();
                        Interlocked.Add(ref totalTimeNs, (long)sw.Elapsed.TotalNanoseconds);
                    }, threadCount);
                    table.AddRow(
                        threadCount.ToString(),
                        $"{1d * totalTimeNs / iterationCount / threadCount}"
                    );
                
                }
            }
        }

        AnsiConsole.Write(table);
    }

    private static void ExecuteConcurrently(Action action, int parallelism)
    {
        var threads = new Thread[parallelism];
        for (int i = 0; i < parallelism; i++)
        {
            threads[i] = new Thread(_ => action());
            threads[i].Start();
        }

        for (int i = 0; i < parallelism; i++)
        {
            threads[i].Join();
        }
    }
}