using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MTC.Persistence.Database;
using MTC.Service;

namespace MTC.Core.Api
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
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(
                opts => opts.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1",new OpenApiInfo()
            //    {
            //        Title = "MTC Api Services Angular Client",
            //        Version = "v1"
            //    });
            //});
            //services.AddIdentity<ApplicationUser, ApplicationRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequiredUniqueChars = 1;
            //});

            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IPersonalService, PersonalService>();

            services.AddAutoMapper(typeof(Startup));

            //var key = Encoding.ASCII.GetBytes(
            //    Configuration.GetValue<string>("SecretKey")
            //);

            //services.AddAuthentication(x =>
            //    {
            //        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    }
            //).AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = false; // es true si en PRD se cuenta con un certificado SSL
            //    x.SaveToken = true; // TOken disponible dentro del request actual
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key), // contiene info Secret Key
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
            //    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "v1");
            //    c.RoutePrefix = string.Empty;
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           
            app.UseRouting();

            //app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
