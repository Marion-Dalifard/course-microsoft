using Microsoft.AspNetCore.Mvc;

namespace Leonardo.Web.Controllers;

[ApiController] 
[Route("[controller]")] 
public class FibonacciController : ControllerBase 
{ 
    private readonly Fibonacci _fibonacci;
    public FibonacciController(Fibonacci fibonacci) 
    { 
        _fibonacci = fibonacci; 
    } 
    
    [HttpGet]
    public async Task<IList<int>> 
        OnPostFibonacciAsync() 
    { 
        var results = await _fibonacci.RunAsync(new []{"44", "44"});
        return results;
    } 
} 
