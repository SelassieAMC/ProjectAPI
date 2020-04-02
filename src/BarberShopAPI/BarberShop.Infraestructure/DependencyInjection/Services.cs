using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
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

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            var contextDbSets = GetAllDbSet(services);

            foreach(var entityName in contextDbSets){
                var fullname = entityName;
                var type = Type.GetType(fullname);
                AddRepoService(services, type);
            }
            return services;
        }

        private static void AddRepoService(IServiceCollection services, Type type)
        {
            var serviceType = typeof(Repository<>).MakeGenericType(type);
            var iServiceType = typeof(IRepository<>).MakeGenericType(type);
            services.AddScoped(iServiceType, serviceType);
        }

        private static IEnumerable<string> GetAllDbSet(IServiceCollection services)
        {
            var dbEntities = new List<string>();
            var serviceDbContext = services.Where( s => s.ImplementationType?.Name == typeof(BarberShopContext).Name).SingleOrDefault();

            var properties = serviceDbContext.ImplementationType.GetProperties().Where(x => x.CanWrite);
            foreach(var property in properties){
                var assemblyName = property.PropertyType.FullName.Split("[[")[1].Split("]]")[0];
                dbEntities.Add(assemblyName);
            }

            return dbEntities;
        }
    }
}