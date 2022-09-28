using System;
using Data.Context;
using Data.Implementations;
using Data.Repository;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Cross.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            // if (Environment.GetEnvironmentVariable("DATABASE")
            //     .ToLower() == "SQLSERVER".ToLower())
            // {
            //     serviceCollection.AddDbContext<MyContext>(
            //         options => options.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION"))
            //     );
            // }
            // else
            // {
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql(
                    Environment.GetEnvironmentVariable("DB_CONNECTION"),
                    new MySqlServerVersion(new Version(8, 0, 30)),
                        mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)
                )
            );
            // }
        }
    }
}
