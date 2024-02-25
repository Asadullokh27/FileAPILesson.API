using FileAPILesson.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Application
{
    public static class ApplicationDependencyInjection
    {

        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }

    }
}
