namespace WeDontNeedPeformanceBench;

public class CpuTests
{
    public static async Task Calc(Action workload, int times)
    {
        var work = new List<Task>();
        
        for (var i = 0; i < times; i++)
        {
            work.Add(Task.Run(workload));
        }
        await Task.WhenAll(work);
    }

}