﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.DataAccess.Repositories;
using NA.Kinjo.Entities;

namespace NA.Kinjo.Api
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
            var customSettings = Configuration.GetSection("CustomSettings").Get<CustomSettings>();
            services.AddSingleton(customSettings);

            services.AddMvc();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("MustBeAdmin",
                    policy =>
                    {
                        policy.RequireAuthenticatedUser().RequireRole("Admin");
                    });
            });

            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
