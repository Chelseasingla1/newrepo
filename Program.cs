// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("hello", () => "Hello World");
app.MapGet("helloobj", () => new{
    Hello ="World is mine" // here Hello is variable or object 
});

app.MapGet("add/{num1}/{num2}" , (int num1, int num2) => $"Sum: {num1 + num2}");

app.MapGet("hello/{name}", (string name) => $"Hello, {name}!");
//app.MapGet();
app.Run();
