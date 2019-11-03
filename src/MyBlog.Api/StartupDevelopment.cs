using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyBlog.Api.Extensions;
using MyBlog.Core.Interfaces;
using MyBlog.Infrastructure.DataBase;
using MyBlog.Infrastructure.Repositories;
using MyBlog.Infrastructure.Resources;
using MyBlog.Infrastructure.Services;
using Newtonsoft.Json.Serialization;
using System.Linq;


namespace MyBlog.Api
{
    public class StartupDevelopment
    {
        private static IConfiguration Configuration { get; set; }

        public StartupDevelopment(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(
            //    options =>
            //    {
            //        options.ReturnHttpNotAcceptable = true;
            //        // options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());

            //        var outputFormatter = options.OutputFormatters.OfType<JsonOutputFormatter>().FirstOrDefault();
            //        if (outputFormatter != null)
            //        {
            //            outputFormatter.SupportedMediaTypes.Add("application/vnd.cgzl.hateoas+json");
            //        }

            //    })
            //    .AddJsonOptions(options =>
            //    {
            //        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //    });

            services.AddMvc();
            services.AddDbContext<MyContext>(options => { options.UseSqlite("DataSource=BlogDemo.db"); });
            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 5001;
            });

            services.AddTransient<IValidator<PostResource>, PostResourceValidator>();

            services.AddSingleton<Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper>(factory =>
            {
                var actionContext = factory.GetService<IActionContextAccessor>().ActionContext;
                return new UrlHelper(actionContext);
            });

            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper();
            var propertyMappingContainer = new PropertyMappingContainer();
            propertyMappingContainer.Register<PostPropertyMapping>();
            services.AddSingleton<IPropertyMappingContainer>(propertyMappingContainer);

            services.AddTransient<ITypeHelperService, TypeHelperService>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseMyExceptionHandler(loggerFactory);

            app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}
