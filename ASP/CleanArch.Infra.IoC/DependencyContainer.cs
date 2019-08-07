using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandler;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Domain InMemoryBus Handler
            service.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            service.AddScoped<IRequestHandler<CreateCourseCommand , bool> , CourseCommandHandler>();

            //Application Layer
            service.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer Repository
            service.AddScoped<ICourseRepository, CourseRepository>();

            //Add DbContext
            service.AddScoped<UniversityDBContext>();
        }
    }
}
