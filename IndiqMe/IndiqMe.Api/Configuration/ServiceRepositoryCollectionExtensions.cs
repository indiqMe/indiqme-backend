using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using IndiqMe.Domain;
using IndiqMe.Domain.Validators;
using IndiqMe.Repository;
using IndiqMe.Repository.Infra;
using IndiqMe.Repository.Infra.CrossCutting.Identity.Configurations;
using IndiqMe.Repository.Infra.CrossCutting.Identity.Interfaces;
using IndiqMe.Service;
using IndiqMe.Service.Upload;

namespace IndiqMe.Api.Configuration
{
    public static class ServiceRepositoryCollectionExtensions
    {
        public static IServiceCollection RegisterRepositoryServices(
           this IServiceCollection services)
        {
            //services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<IContactUsEmailService, ContactUsEmailService>();


            //repositories
            services.AddScoped<IUserRepository, UserRepository>();

            //validators
            services.AddScoped<IValidator<User>, UserValidator>();
            services.AddScoped<IValidator<ContactUs>, ContactUsValidator>();

            //Auth
            services.AddScoped<IApplicationSignInManager, ApplicationSignInManager>();

            //Email 
            services.AddScoped<IEmailService, EmailService>();
            services.AddSingleton<IEmailTemplate, EmailTemplate>();

            //Upload 
            services.AddScoped<IUploadService, UploadService>();

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
