

using Medical_Platform.Controller;
using Medical_Platform.Database;
using Medical_Platform.Manager;
using Medical_Platform.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Medical_Platform

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
            services.AddScoped<UserRepository>();
            services.AddScoped<UserManager>();

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
