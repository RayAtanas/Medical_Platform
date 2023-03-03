using Appointments.Manager;
using Appointments.Repository;
using Appointments.Database;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Appointments.Entity;
using Microsoft.VisualStudio.Settings;
using AutoMapper;
using Appointments.Mapper;
using Appointments.Entity.DTO;

namespace Appointments
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddMvc();
            services.AddScoped<Context>();
            services.AddScoped<MongoRepository>();
            //  services.AddTransient<IMongoRepository>();
           services.AddScoped<Appointment, Appointment>();
            services.AddScoped<AppointmentsManager>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AppointmentMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);


            //services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // app.UseHttpsRedirection();
            //  app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            // app.MapRazorPages();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
