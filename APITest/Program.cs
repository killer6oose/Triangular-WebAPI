using APITest.Calculators.GridReferenceCalculators;
using APITest.Calculators.TriangleCalculators;
using Triangular.BLL.Calculators.GridReferenceCalculators;
using Triangular.BLL.Calculators.TriangleCalculators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGridReferenceByTriangleCalculator, GridReferenceByTriangleCalculator>();
builder.Services.AddScoped<ITriangleByGridReferenceCalculator, TriangleByGridReferenceCalculator>();
builder.Services.AddScoped<ITriangleCalculatorFactory, TriangleCalculatorFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();