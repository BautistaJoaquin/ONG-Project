﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using OngProject.Application.Services;

namespace OngProject.Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<MemberService>();
            services.AddScoped<ActivityService>();
            services.AddScoped<NewsService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<OrganizationService>();

            return services;
        }
    }
}