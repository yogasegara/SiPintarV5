using AppBusiness.Business.Impl;
using AppBusiness.Impl.Services;
using AppBusiness.Interface;
using AppPersistence.Interface;
using AppPersistence.Mysql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RestApi
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
            #region ADD Persistence
            services.AddSingleton<IPersistence>(new Persistence());
            #endregion

            #region ADD Bussiness
            services.AddSingleton<IBusiness, Business>();
            #endregion

            #region ADD Service
            services.AddSingleton<IPelangganService, PelangganService>();
            services.AddSingleton<IRayonService, RayonService>();
            services.AddSingleton<IWilayahService, WilayahService>();
            services.AddSingleton<IAreaService, AreaService>();
            services.AddSingleton<IKelurahanService, KelurahanService>();
            services.AddSingleton<IKecamatanService, KecamatanService>();
            services.AddSingleton<ICabangService, CabangService>();


            #endregion

            services.AddControllers();

            #region swagger

            services.AddSwaggerGen();

            #endregion
        }
      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SiPintar V.5");
                c.RoutePrefix = string.Empty;
            });
            #endregion

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}