using CRM.Models.Inits;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Extensions
{
    public static class AppDbContextOptionsExtension
    {
        public static void InitializeDb(this IServiceProvider serviceProvider)
        {
            var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var dbInitialize = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
                dbInitialize.Initialize();
            }
        }

        public static void AddDefault(this IServiceProvider serviceProvider)
        {
            var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var dbInitialize = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
                dbInitialize.AddDefautlUser();
            }
        }
    }
}
