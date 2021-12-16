using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceRegistation
    {
        public static void AddApplicationRegistation(this IServiceCollection services)
        {
            var assmbly=Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assmbly);
            services.AddMediatR(assmbly);
        }
    }
}
