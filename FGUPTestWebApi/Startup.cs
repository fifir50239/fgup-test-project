using FgupBL.Services;
using FgupBL.Services.Implementation;
using FgupDAL.Context.Implementation;
using FgupDAL.Repositories;
using FgupDAL.Repositories.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FGUPTestWebApi
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
            services.AddDbContext<TestDbContext>(options => options.UseInMemoryDatabase(databaseName: "TestModels"));

            services.AddControllers();
            services.AddMvc();

            services.AddSwaggerGen(g =>
            {
                g.SwaggerDoc("v1", new OpenApiInfo { Title = "FGUPTestApi", Version = "v1" });
            });

            #region dal

            services.AddScoped<IFederalDistrictRepository, FederalDistrictRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            
            #endregion


            #region bl

            services.AddScoped<ITableDataService, TableDataService>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FGUPTestApi V1");
            });
        }
    }
}
