using BlogApp.DAL.Repositories.Interfaces;
using BlogAppBusiness.Services.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppBusiness
{
    public static class BusinessServiceRegistrations
    {
        public static void  AddBService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BusinessServiceRegistrations));
            services.AddScoped<ICategoryService, ICategoryService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
