using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatorCQRS_NUnit.Application
{
    public static class RegisterService
    {
        public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(_=>_.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}