using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TesteSquadra.Interface;
using TesteSquadra.Interface.Repository;
using TesteSquadra.Repository;
using TesteSquadra.Services;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
//using Swashbuckle.AspNetCore.Swagger;
//using Microsoft.OpenApi.Models;

namespace TesteSquadra
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            

            //services.AddSwaggerGen((options) =>
            //{
            //    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Teste Squadra", Version = "V1" });
            //});
            services.AddScoped<ITaxaJuros, TaxaJurosService>();
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();
            services.AddScoped<ICalcularJuros, CalcularJurosService>();
            services.AddScoped<ICalcularJurosRepository, CalcularJurosRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MY API V1");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
