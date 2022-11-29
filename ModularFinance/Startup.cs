using Microsoft.OpenApi.Models;
using Module.Account;
using Shared.Infrastucture.Extensions;

namespace ModularFinance
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSharedInfrastructure(Configuration);
            services.AddAccount(Configuration);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                c.ConfigObject.AdditionalItems.Add("syntaxHighlight", false); //przyspiesza dzialanie swaggera
            }
            );

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
