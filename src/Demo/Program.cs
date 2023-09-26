using Leonardo;

var results =  new Fibonacci().RunAsync(args);
Console.WriteLine($"Finished");
results.Wait();