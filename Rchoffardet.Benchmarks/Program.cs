using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Rchoffardet.Benchmarks.ExceptionPerformance;

var config = DefaultConfig.Instance;
var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
//ExceptionCpuContentionStopWatch.Main();