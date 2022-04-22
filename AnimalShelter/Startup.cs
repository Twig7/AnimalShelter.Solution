using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.IO;

namespace AnimalShelter
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

            services.AddDbContext<AnimalShelterContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();

            // registered the Swagger generator, defining one or more Swagger documents.
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
            {
                Title = "Animal Shelter Api",
                Version = "v1", 
                Description = "A .NET web API for helping organize animals at an animal shelter!",
                Contact = new OpenApiContact
                {
                Name = "Amber Wilwand",
                Url = new Uri("https://github.com/Twig7")
                },
                // License = new OpenApiLicense
                // {
                // Name = "Use under AFL",
                // Url = new Uri("https://opensource.org/licenses/AFL-3.0"),
                // }
            });
        });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // exposed the generated Swagger as JSON endpoint(s) using middleware
                app.UseSwagger(c =>
                {
                    c.SerializeAsV2 = true;
                });
                    // inserted the swagger-ui middleware to expose interactive documentation, specifying the Swagger JSON endpoint(s) to power it from
                    app.UseSwaggerUI(c => 
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalShelterApi v1");
                    c.RoutePrefix = string.Empty;
                });
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}