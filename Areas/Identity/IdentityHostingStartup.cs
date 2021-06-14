using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SnakisApp.Areas.Identity.Data;
using SnakisApp.Data;

[assembly: HostingStartup(typeof(SnakisApp.Areas.Identity.IdentityHostingStartup))]
namespace SnakisApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SnakisAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SnakisAppContextConnection")));

                services.AddDefaultIdentity<SnakisAppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<SnakisAppContext>();
            });
        }
    }
}