using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Triangular.BLL.Factories;
using Triangular.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGridReferenceByTriangleCalculator, GridReferenceByTriangleCalculator>();
builder.Services.AddScoped<ITriangleByGridReferenceCalculator, TriangleByGridReferenceCalculator>();
builder.Services.AddScoped<ITriangleCalculatorFactory, TriangleCalculatorFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}
else if (app.Environment.IsProduction())
{
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1.0/swagger.json", "v1.0");
        options.RoutePrefix = "api/swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// This code was developed by and written by myself, Andrew Hatton, for the purpose of the Software
// Engineer interview task. For questions about this feel free to email me at andrewhatton(at)cronotech.us