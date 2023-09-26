using System.Diagnostics;

namespace Leonardo;

public class Fibonacci
{
    private static int Run(int i)
    {
        if (i <= 2)
            return 1;
        return Run(i - 1) + Run(i - 2);
    }

    public async Task<IList<int>> RunAsync(string[] args)
    {
        var results = new List<int>();
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var tasks = args.Select(arg => Task.Run(() =>
        {
            var result = Fibonacci.Run(int.Parse(arg));
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms {arg}");
            return result;
        })).ToList();
        
        foreach (var task in tasks)
        {
            var result = await task;
            Console.WriteLine($"Result: {result}");
            results.Add(result);
        }
        stopwatch.Stop();
        Console.WriteLine("Total elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);

        return results;
    }
}