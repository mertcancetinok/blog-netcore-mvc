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
            services.AddScoped<blog.data.Abstract.ICommentRepository, EfCoreCommentRepository>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBloggerService, BloggerManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICommentService, CommentManager>();
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
                name:"blogcategories",
                pattern:"kategori/{url}",
                defaults: new {Controller="Home",Action="BlogList"}
                );
                endpoints.MapControllerRoute(
                name:"blogdetails",
                pattern:"blog/{url}",
                defaults:new {Controller="Home", Action= "BlogDetails"}
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
