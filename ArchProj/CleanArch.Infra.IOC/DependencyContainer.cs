using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Intefaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IOC
{
   public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddScoped<ICoursesService,CoursesService>();

            service.AddScoped<ICoursesRepository,CourseRepository>();
        }
    }
}
