using System;
using E_Rosario.Areas.Identity.Data;
using E_Rosario.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(E_Rosario.Areas.Identity.IdentityHostingStartup))]
namespace E_Rosario.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<E_RosarioDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("E_RosarioDbContextConnection")));

                services.AddDefaultIdentity<E_RosarioUser>(options => { 
                options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                 }


                )
                
                    .AddEntityFrameworkStores<E_RosarioDbContext>();
            });
        }
    }
}