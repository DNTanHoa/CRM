using CRM.Models.Contexts;
using CRM.Models.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Models.Inits
{
    public interface IDbInitializer
    {
        void Initialize();

        void AddDefautlUser();
    }
    public class DbInitializer : IDbInitializer
    {
        private readonly IServiceScopeFactory scopeFactory;

        public DbInitializer(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public void AddDefautlUser()
        {
            using (var serviceScope = scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    if (context.User.Count() == 0)
                    {
                        var user = new User()
                        {
                            username = "admin",
                            password = "Admin@123",
                        };
                        user.SetPassword();
                        context.User.Add(user);
                        context.SaveChanges();
                    }
                }
            }
        }

        public void Initialize()
        {
            using (var serviceScope = scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
