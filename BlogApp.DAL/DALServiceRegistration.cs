using BlogApp.DAL.Repositories.Implementations;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL
{
    public static class DALServiceRegistration
    {
        public static void AddDService(this IServiceCollection services)
        {
            services.AddScoped<ICategorRepository, CategoryRepository>();

        }
    }
}
