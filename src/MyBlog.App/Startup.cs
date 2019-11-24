﻿using Autofac;
using Autofac.Annotation;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.View;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyBlog.App.Filter;
using Newtonsoft.Json.Serialization;
using Repository.Services;
using System;

namespace MyBlog.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("Any", r =>
            {
                r.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            services.AddScoped<IViewRenderService, ViewRenderService>();
            services.AddMvc(o => { o.Filters.Add<GlobalExceptionFilter>(); })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .AddControllersAsServices();



            services.AddHttpContextAccessor();

            var builder = new ContainerBuilder();
            builder.Populate(services);

            //autofac打标签模式 文档：https://github.com/yuzd/Autofac.Annotation
            builder.RegisterModule(new AutofacAnnotationModule(this.GetType().Assembly, typeof(BaseRepository<>).Assembly)
                .SetAllowCircularDependencies(true)
                .SetDefaultAutofacScopeToInstancePerLifetimeScope());

            var container = builder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            Infrastructure.Web.HttpContext.ServiceProvider = serviceProvider;
            return serviceProvider;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logging)
        {

            #region AntORM
            //文档：https://github.com/yuzd/AntData.ORM
            app.UseAntData();
            #endregion

            #region AutoMapperConfig
            var autoMapperConfig = new Mapping.AutoMapper();
            autoMapperConfig.ExecuteByAssemblyName("DbModel", "ServicesModel");
            #endregion

            app.UseStaticFiles();

            app.UseStatusCodePagesWithReExecute("/admin/error/{0}");

            app.UseMvc(routes =>
            {
                // areas
                routes.MapRoute(
                    name: "Admin",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
