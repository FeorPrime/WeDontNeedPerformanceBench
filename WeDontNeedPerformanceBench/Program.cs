// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using WeDontNeedPeformanceBench;

Console.WriteLine("Hello, World!");

var summary = BenchmarkRunner.Run<Bench>();