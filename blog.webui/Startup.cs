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
using Microsoft.EntityFrameworkCore;
using blog.webui.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using blog.entity;

namespace blog.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection")));
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddScoped<blog.data.Abstract.IBlogRepository, EfCoreBlogRepository>();
            services.AddScoped<blog.data.Abstract.ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<blog.data.Abstract.ICommentRepository, EfCoreCommentRepository>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = ".Blog.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
                options.LoginPath = "/Admin/Login";
                options.AccessDeniedPath = "/Admin/AccessDenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });
        
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

            app.UseAuthentication();
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
