using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shoppinglist.API.Domain.Repositories;
using Shoppinglist.API.Domain.Services;
using Shoppinglist.API.Persistence.Contexts;
using Shoppinglist.API.Persistence.Repositories;
using Shoppinglist.API.Services;
//using Oracle.ManagedDataAccess.Client;

namespace Shoppinglist.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // services.AddDbContext<AppDbContext>(options =>
            // {
            //     options.UseInMemoryDatabase("Shoppinglist-api-in-memory");
            // });

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseOracle(@"User Id=hr;Password=hr;Data Source=localhost:1521/xe");
            });




            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            
        }
    }
}