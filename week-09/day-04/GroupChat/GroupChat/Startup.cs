﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using GroupChat.Entities;
using Microsoft.EntityFrameworkCore;
using GroupChat.Models;
using GroupChat.Repositories;
using GroupChat.Services;
using GroupChat.ViewModels;

namespace GroupChat
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<MessageContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GroupChat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddScoped<MessageContext>();
            services.AddScoped<Message>();
            services.AddScoped<MessageRepository>();
            services.AddScoped<MessageService>();
            services.AddScoped<MessageViewModel>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
