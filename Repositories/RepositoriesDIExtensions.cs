﻿using BooksApiApp.Repositories;

namespace BooksApiApp.Repositories
{
    public static class RepositoriesDIExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }       //Extension Method
}
