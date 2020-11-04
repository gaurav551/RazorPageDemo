using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace RazorConstruction
{


    //Extension Method Password Settings
    public static class Password
    {
        public static void PasswordSetting(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
          {
              options.Password.RequireDigit = true;
              options.Password.RequireNonAlphanumeric = false;
              options.Password.RequireUppercase = false;
              options.Password.RequireLowercase = false;
              //Time user is locked out after fail login attempts
              options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
              options.Lockout.MaxFailedAccessAttempts = 5;
              options.Lockout.AllowedForNewUsers = true;
          });
            //Removes Identity Part from the URL



        }
    }
}
