using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BarberShop.Core.Entities;
using BarberShop.Core.Interfaces;
using BarberShop.Infraestructure.DataAccess;
using BarberShop.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberShop.Infraestructure.DependencyInjection
{
    public static class Services
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<BarberShopContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BarberShopDatabase"), 
                b => b.MigrationsAssembly(typeof(BarberShopContext).Assembly.FullName)));
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            IEnumerable<string> contextDbSets = GetAllDbSet(services);
            
            services.AddScoped<IRepository<DocumentType>, Repository<DocumentType>>();
            services.AddScoped<IRepository<Service>, Repository<Service>>();
            services.AddScoped<IRepository<Person>, Repository<Person>>();
            services.AddScoped<IRepository<Employee>, Repository<Employee>>();
            services.AddScoped<IRepository<Customer>, Repository<Customer>>();
            return services;
        }

        private static IQueryable<string> GetAllDbSet(IServiceCollection services)
        {
            var serviceDbContext = services.Where( s => s.ImplementationType?.Name == "BarberShopContext").SingleOrDefault();
            
            IQueryable<string> entities = serviceDbContext.ImplementationType.GetProperties().Where(x => x.CanWrite).Select(x => x.Name).AsQueryable();

            return entities;
        }
    }
}