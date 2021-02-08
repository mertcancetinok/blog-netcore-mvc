using blog.data.Concrete.EfCore;
using blog.data.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.business.Concrete;

namespace blog.webui
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
            services.AddControllersWithViews();
            services.AddScoped<blog.data.Abstract.IBlogRepository, EfCoreBlogRepository>();
            services.AddScoped<blog.data.Abstract.IBloggerRepository, EfCoreBloggerRepository>();
            services.AddScoped<blog.data.Abstract.ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBloggerService, BloggerManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "categoryedit",
                    pattern: "admin/kategori/{id}",
                    defaults: new { Controller = "Admin", Action = "CategoryEdit" }
                    );
                endpoints.MapControllerRoute(
                    name: "categories",
                    pattern: "admin/kategori",
                    defaults: new {Controller="Admin",Action="Category"}
                    );
                
                endpoints.MapControllerRoute(
                    name: "adminblogger",
                    pattern: "admin/blogger",
                    defaults: new { Controller = "Admin", Action = "Blogger" }
                    );
                endpoints.MapControllerRoute(
                    name: "adminbloggerdetails",
                    pattern: "admin/bloggers/{id?}",
                    defaults: new { Controller = "Admin", Action = "BloggerEdit" }
                    );
                endpoints.MapControllerRoute(
                    name:"adminblogs",
                    pattern:"admin/blog",
                    defaults: new {Controller="Admin",Action="Blog"} 
                    );
                endpoints.MapControllerRoute(
                    name: "adminblogs",
                    pattern: "admin/blogs/{id?}",
                    defaults: new { Controller = "Admin", Action = "BlogEdit" }
                    );
                endpoints.MapControllerRoute(
                    name:"blogdetails",
                    pattern:"{url}",
                    defaults:new {Controller="Home", Action= "BlogDetails"}
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
