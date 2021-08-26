using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iaf.API.Data;
using Iaf.API.Data.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Iaf.API.Models.Common;
using Microsoft.AspNetCore.Http.Features;
using Oracle.EntityFrameworkCore;

namespace Iaf.API
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
            //services.AddDbContext<DataContext>(x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("PortalConnectionProd")));
            //services.AddDbContext<DataContext2>(x => x.UseSqlServer(Configuration.GetConnectionString("WSFCSConnection")));
            services.AddDbContext<DataContext>(x => x.UseOracle(Configuration.GetConnectionString("MbspConnection")));

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                // Use the default property (Pascal) casing
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                // Configure a custom converter
                // options.SerializerOptions.Converters.Add(new MyCustomJsonConverter());
            });
            // services.AddMvc(options =>
            // {

            // })
            // .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddCors();
            services.AddAutoMapper(typeof(TicketRepository).Assembly);
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>(); 
            // services.AddScoped<IUsersRepository, UsersRepository>();              
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                options => {
                    options.TokenValidationParameters = new TokenValidationParameters(){
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                }
            );
            services.Configure<IISServerOptions>(options => 
            {
                options.AutomaticAuthentication = false;
            }); 
            services.Configure<IISOptions>(options => 
            {
                options.ForwardClientCertificate = false;
            });  
                    
            var emailConfig = Configuration
                    .GetSection("EmailConfiguration")
                    .Get<EmailConfiguration>();
                services.AddSingleton(emailConfig);

            services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });     
            
            services.AddHttpContextAccessor();                                    
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            //app.UseCors(x => x.WithOrigins("http://localhost:4200").WithOrigins("http://localhost:7800").AllowAnyMethod().AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseMvc();
        }
    }
}
