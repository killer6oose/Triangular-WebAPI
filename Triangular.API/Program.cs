﻿using Microsoft.AspNetCore.Builder;
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
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();