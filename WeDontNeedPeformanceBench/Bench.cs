using BenchmarkDotNet.Attributes;
using WeDontNeedPeformanceBench;
// ReSharper disable MemberCanBePrivate.Global

namespace WeDontNeedPeformanceBench;

[MemoryDiagnoser]
public class Bench
{
    private readonly CpuTests _cpu = new();
    private readonly RAMTests _ram = new();
    
    [Params(100,1000,10000)] public int Threads { get; set; }

    [Params( 9999999999)] public long A { get; set; }
    
    [Params( 4444444444)] public long B { get; set; }

    [Benchmark]
    public async Task CpuBoundMetricAdd()
        => await CpuTests.Calc(() => _ = A + B, Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricMulti()
        => await CpuTests.Calc(() => _ = A * B, Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricSuperPower()
        => await CpuTests.Calc(() => _ = Math.Pow(A,32), Threads);
    
    [Benchmark]
    public async Task CpuBoundMetricSuperRoot()
        => await CpuTests.Calc(() => _ = Math.Sqrt(A), Threads);
    
    [Benchmark]
    public async  Task RamBoundMetricText()
    {
        await _ram.Create(Threads);
    }
    
    [Benchmark]
    public async  Task RamBoundMetricLongArray()
    {
        await _ram.CreateArray(Threads);
    }

    // [Benchmark]
    // public async Task IoBoundMetric()
    // {
    //     //await Task.Delay(10);
    // }
}