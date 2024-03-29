using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Store.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Book_Store
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer("Server=.;Database=BookStore;User ID=sa;password=123ASD456ZXC5a"));

            #if DEBUG
                services.AddRazorPages().AddRazorRuntimeCompilation();
            #endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Enabling middlewares
            app.UseRouting();
            app.UseStaticFiles();

            //Middleware
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                /*endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "bookApp/{controller=Home}/{action=Index}/{id?}");*/
            });
        }
    }
}
