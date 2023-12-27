using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PestKitOnionAB104.Application.Abstractions.Repositories;
using PestKitOnionAB104.Application.Abstractions.Services;
using PestKitOnionAB104.Domain.Entities;
using PestKitOnionAB104.Persistence.Contexts;
using PestKitOnionAB104.Persistence.Implementations.Repositories;
using PestKitOnionAB104.Persistence.Implementations.Services;

namespace PestKitOnionAB104.Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("default")));

            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
                opt.User.RequireUniqueEmail = true;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();


            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
