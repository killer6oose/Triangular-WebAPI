using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Triangular.BLL.Calculators.TriangleCalculators;
using Triangular.BLL.Calculators.GridReferenceCalculators;

namespace Triangular.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<TriangleByGridReferenceCalculator>();
            services.AddScoped<ITriangleCalculatorFactory, TriangleCalculatorFactory>();

            services.AddScoped<GridReferenceByTriangleCalculator>();

            services.AddCors(options =>
            {
                options.AddPolicy("_myAllowSpecificOrigins",
                builder =>
                {
                    builder.WithOrigins("https://localhost:44343").AllowAnyHeader().AllowAnyMethod();
                });
            });

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("_myAllowSpecificOrigins");
            app.UseMvc();
        }
    }
}
