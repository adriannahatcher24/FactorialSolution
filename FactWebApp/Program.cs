using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FactorialCalculator; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Fact/Error"); 
    app.UseHsts();
}

app.MapGet("/factorial/{number}", async (HttpContext context, int number) => 
{
    var calculator = new FactorialCalculator.FactorialCalc(); 
    long result;
    try
    {
        result = calculator.Calculate(number);
    }
    catch (Exception ex)
    {
        context.Response.StatusCode = 400; 
        await context.Response.WriteAsync(ex.Message);
        return;
    }
    await context.Response.WriteAsync($"The factorial of {number} is: {result}");
});

app.Run();

