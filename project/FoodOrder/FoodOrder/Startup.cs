using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using FoodOrder.Entities;
using FoodOrder.Models;
using FoodOrder.Repositories;
using FoodOrder.Services;

namespace FoodOrder
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<FoodOrderContext>(options =>options.UseNpgsql(Configuration["Conectionstring"]));
            services.AddScoped<OrderedFoodModel>();
            services.AddScoped<MenuModel>();
            services.AddScoped<UserModel>();
            services.AddScoped<OrderFoodRepository>();
            services.AddScoped<OrderFoodService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
