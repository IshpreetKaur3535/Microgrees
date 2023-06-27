using MicrogreensWebsite.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrogreensWebsite
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
            services.AddDbContext<AppDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString
          ("DefaultConnection")));

            // add identity consumption with users at start up
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
           
            services.AddControllersWithViews();
          
            services.AddSession();
            services.AddRazorPages();
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
            

            app.UseEndpoints(async endpoints =>
            {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            endpoints.MapRazorPages();

                // seeding roles in the aspNetRoles table in the database
            using (var scope = app.ApplicationServices.CreateScope())
            {
                    
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    //created an array which stores roles
                var roles = new[] { "Admin", "Employee", "Farmer" };

                   
                foreach (var role in roles)
                {
                        // checking whether the role exists in the database  or not, if not then create 
                    if (!await roleManager.RoleExistsAsync(role))
                            await roleManager.CreateAsync(new IdentityRole(role));
                    }
                }

                // Assign role to User Admin of the website and seeding the data to the databse 
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    string email = "Admin2@gmail.com";
                    string passwrod = "Test!234";

                    if (await userManager.FindByEmailAsync(email) == null)
                    {
                        var user = new IdentityUser();
                        user.UserName = email;
                        user.Email = email;

                        await userManager.CreateAsync(user, passwrod);

                        // assign the role to the user
                        await userManager.AddToRoleAsync(user, "Admin");
                    }
                }

                // Assign role to User Employee of the website and seeding the data to the databse 
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    string email = "Employee@gmail.com";
                    string passwrod = "Test!2345";

                    if (await userManager.FindByEmailAsync(email) == null)
                    {
                        var user = new IdentityUser();
                        user.UserName = email;
                        user.Email = email;

                        await userManager.CreateAsync(user, passwrod);
                        // assign the role to the user
                        await userManager.AddToRoleAsync(user, "Employee");
                    }
                }

                // Assign role to User Farmer of the website and seeding the data to the databse 
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    string email = "Mark@gmail.com";
                    string passwrod = "Test!2345";

                    if (await userManager.FindByEmailAsync(email) == null)
                    {
                        var user = new IdentityUser();
                        user.UserName = email;
                        user.Email = email;

                        await userManager.CreateAsync(user, passwrod);
                        // assign the role to the user
                        await userManager.AddToRoleAsync(user, "Farmer");
                    }
                }
                    using (var scope = app.ApplicationServices.CreateScope())
                    {
                        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                        string email = "John@gmail.com";
                        string passwrod = "Test!2345";

                        if (await userManager.FindByEmailAsync(email) == null)
                        {
                            var user = new IdentityUser();
                            user.UserName = email;
                            user.Email = email;

                            await userManager.CreateAsync(user, passwrod);
                        // assign the role to the user
                        await userManager.AddToRoleAsync(user, "Farmer");
                        }
                    }

            });
        }
    }
}
