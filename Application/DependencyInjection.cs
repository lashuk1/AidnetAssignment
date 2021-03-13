using Application.Implementation;
using Application.Implementation.Repositories;
using Application.Implementation.Services;
using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) // ექსთენშენ მეთოდი
        {
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ICarFeaturesRepository, CarFeaturesRepository>();

            services.AddTransient<ICarService, CarService>();
            services.AddTransient<ICarFeaturesService, CarFeaturesService>();

            return services;
        }
    }
}
