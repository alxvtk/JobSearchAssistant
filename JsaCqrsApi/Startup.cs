using JsaCqrsApi.Context;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace JsaCqrsApi
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
            services.AddDbContext<ApplicationContext>
            (options =>
                options.UseSqlServer
                (
                    Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)
                )
            );

            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());

            services.AddControllers();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            #region Swagger
            string xmlTitleName = "JsaCqrsApi";
            services.AddSwaggerGen
            (c =>
            {
                //c.IncludeXmlComments(string.Format(@"{0}\Jsa.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                c.IncludeXmlComments(string.Format(@"{0}\{1}", System.AppDomain.CurrentDomain.BaseDirectory, xmlTitleName + ".xml"));
                c.SwaggerDoc
                ("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = xmlTitleName,
                        //Title = "EFCore.CodeFirst.WebApi",
                    }
                );
            }
            );
            #endregion

        }


        /*
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JsaCqrsApi", Version = "v1" });
            });
        }
        */

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JsaCqrsApi v1"));
            }
            */

            #region Swagger
            string xmlTitleName = "JsaCqrsApi";

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "jsaCqrsApi_01");
                //c.SwaggerEndpoint("/swagger/v1/swagger.json", "EFCore.CodeFirst.WebApi");
            });
            #endregion


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
