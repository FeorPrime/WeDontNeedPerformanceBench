using System.Numerics;

namespace WeDontNeedPerformanceBench;

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

    public static Task MatrixMultiply()
    {
        _ = Matrix4x4.Multiply(CreateRandom(), CreateRandom());
        return Task.CompletedTask; 
    }

    private static Matrix4x4 CreateRandom()
    {
        var result = new Matrix4x4();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = Random.Shared.NextSingle();
            }
        }

        return result;
    }
    
    
}