﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

using DAL;

namespace WebAPI
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
            services.AddDbContext<StoreContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"),
                    b => b.MigrationsAssembly(@"WebAPI")
                ));                

            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IRoleService, RoleService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //seed
            }
            else
            {
                app.UseHsts();
            }
            serviceScope.Dispose();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
