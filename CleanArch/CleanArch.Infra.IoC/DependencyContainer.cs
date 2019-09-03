﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Core.Bus;
using CleanArch.Infra.Bus;
using MediatR;
using CleanArch.Domain.Commands;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();


        }
    }
}
