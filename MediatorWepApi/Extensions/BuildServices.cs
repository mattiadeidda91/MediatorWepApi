using MediatorWepApi.Factory;
using MediatorWepApi.Models;
using MediatorWepApi.Repository;
using MediatorWepApi.Repository.Interfaces;
using MediatorWepApi.Services;
using MediatorWepApi.Services.Interfaces;

namespace MediatorWepApi.Extensions
{
    public static class BuildServices
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            //Services
            services.AddScoped<INotificationFactory, NotificationFactory>();
            services.AddScoped<INotificationFactory, NotificationFactory>();
            services.AddScoped<INotification, EmailService>();
            services.AddScoped<INotification, SmsService>();

            return services;
        }
    }
}
