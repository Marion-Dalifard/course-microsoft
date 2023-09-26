namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var results = await new Fibonacci().RunAsync(new[] { "44" });
        Assert.Equal(701408733, results[0]);
    }
}