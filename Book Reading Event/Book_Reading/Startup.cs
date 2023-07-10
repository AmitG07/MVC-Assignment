using Book_Reading.Models;
using BusinessLayer;
using BusinessLayer.Interface;
using BusinessLayer.Repository;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading
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
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                mig => mig.MigrationsAssembly("DataAccessLayer")));

            services.AddControllersWithViews();

            services.AddTransient<IEvents, Events>();   //Dependency Injection
            /*services.AddTransient<IEventBs, EventBs>();*/
            services.AddTransient<FacadeFactory>();

            services.AddDefaultIdentity<ApplicationUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            /*services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
            });*/
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
            }
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            /*async void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                                            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
            {
                string roleName = "Admin";
                IdentityResult roleResult;

                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }

                // Create admin user
                var user = new IdentityUser
                {
                    UserName = "admin@bookreading.com",
                    Email = "admin@bookreading.com",
                    EmailConfirmed = true
                };

                var userPassword = "Admin@123";
                var userResult = await userManager.CreateAsync(user, userPassword);

                // Add admin user to admin role
                if (userResult.Succeeded)
                {
                    var result = await userManager.AddToRoleAsync(user, roleName);
                }
            }*/
        }
    }
}
