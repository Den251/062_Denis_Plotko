using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public static class ListerServiceConfig
    {
        public static IServiceCollection AddLister(this IServiceCollection services)
        {
            services.AddScoped<ILister, MonthLister>();
            return services;
        }
    }
}
