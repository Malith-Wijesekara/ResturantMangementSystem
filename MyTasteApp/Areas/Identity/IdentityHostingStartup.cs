using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyTasteApp.DataAccess;

[assembly: HostingStartup(typeof(MyTasteApp.Areas.Identity.IdentityHostingStartup))]
namespace MyTasteApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MyTasteAppIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MyTasteAppIdentityDbContextConnection"), x => x.MigrationsAssembly("MyTasteApp.DataAccess.Migrations")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MyTasteAppIdentityDbContext>();
            });
        }
    }
}