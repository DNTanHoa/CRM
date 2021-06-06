using AutoMapper;
using CRM.Extensions;
using CRM.Mapper;
using CRM.Models;
using CRM.Models.Contexts;
using CRM.Models.Inits;
using CRM.Models.Repositories;
using CRM.RequestModel;
using CRM.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); ;

            services.AddFluentValidation();

            services.AddTokenAuthentication(Configuration);

            services.AddDbContext<AppDbContext>();
            services.AddTransient<IDbInitializer, DbInitializer>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserMappingProfile());
                mc.AddProfile(new CustomerMappingProfile());
                mc.AddProfile(new InvoiceMappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vision", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "Oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });

            services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
            services.AddScoped<IGenericRepository<Customer>, GenericRepository<Customer>>();
            services.AddScoped<IGenericRepository<CustomerType>, GenericRepository<CustomerType>>();
            services.AddScoped<IGenericRepository<InvoiceHeader>, GenericRepository<InvoiceHeader>>();
            services.AddScoped<IGenericRepository<InvoiceDetail>, GenericRepository<InvoiceDetail>>();
            services.AddScoped<ICustomerTypeRepository, CustomerTypeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<ISequenceNumberRepository, SequenceNumberRepository>();

            services.AddScoped<IValidator<CustomerCreateOrUpdateRequestModel>, CustomerRequestModelValidator>();
            services.AddScoped<IValidator<InvoiceCreateOrUpdateRequestModel>, InvoiceRequestValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRM v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
