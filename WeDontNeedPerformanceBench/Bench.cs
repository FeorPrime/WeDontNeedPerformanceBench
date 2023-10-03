using BenchmarkDotNet.Attributes;
using WeDontNeedPerformanceBench;
// ReSharper disable MemberCanBePrivate.Global

namespace WeDontNeedPerformanceBench;

[MemoryDiagnoser, ThreadingDiagnoser]
public class Bench
{
    // readonly CpuTests _cpu = new();
    //private readonly RAMTests _ram = new();
    
    [Params(100,1000,10000)] public int Threads { get; set; }

    [Params( 234567894600987)] public long A { get; set; }
    [Params( 786457757474546)] public long B { get; set; }

    [Benchmark]
    public async Task CpuBoundMetricAdd()
        => await CpuTests.Calc(() => _ = A + B, Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricMulti()
        => await CpuTests.Calc(() => _ = Math.BigMul(A,B, out _), Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricSuperPower()
        => await CpuTests.Calc(() => _ = Math.Pow(A,32), Threads);

    [Benchmark]
    public async Task CpuBoundMetricMatrixMultiply()
        => await CpuTests.Calc(() => _ = CpuTests.MatrixMultiply(), Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricSuperRoot()
        => await CpuTests.Calc(() => _ = Math.Sqrt(A), Threads);
    
    // [Benchmark]
    // public async  Task RamBoundMetricText()
    // {
    //     await _ram.Create(Threads);
    // }
    
    [Benchmark]
    public async  Task RamBoundMetricLongArray()
    => await RAMTests.CreateArray(Threads, 1000);

    // [Benchmark]
    // public async Task IoBoundMetric()
    // {
    //     //await Task.Delay(10);
    // }
}