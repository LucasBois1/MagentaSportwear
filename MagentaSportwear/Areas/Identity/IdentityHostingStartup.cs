using MagentaSportwear.Data;
using MagentaSportwear.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Http;

[assembly: HostingStartup(typeof(MagentaSportwear.Areas.Identity.IdentityHostingStartup))]
namespace MagentaSportwear.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString(name: "DefaultConnection"), new MySqlServerVersion(new Version(8,0,25))));
                services.AddDefaultIdentity<ApplicationUser>()
                    .AddSignInManager()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseMySql(context.Configuration.GetConnectionString(name: "DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 25))));
                services.AddIdentityCore<IdentityUser>();
                services.AddAuthentication();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                services.AddRazorPages();
            });
        }
        }
    }