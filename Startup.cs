using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using  Microsoft.EntityFrameworkCore;
using SPVT.Models;

namespace SPVT
{
    public class Startup
    {
        // public void ConfigureServices(IServiceCollection services)
        // {
        //    //Add framework Services ///
        //     services.AddMvc();

        //     services.AddDbContext<SPVTDbContext>(options 
        //                                         => options.UseSqlite("Data Source=SPVT,db"));
        // }

        //   public Startup(IConfiguration configurSation)
        // {
        //      Configuration = configuration;
        // }

        // // public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
         public void ConfigureServices(IServiceCollection services)
         {
             // Add framework services 
            services.AddMvc();

            services.AddDbContext<AutomobileContext>(options =>
                                  options.UseSqlite("Data Source=Cars.db"));

         }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
