using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QLNV.Interface.Chucvu;
using QLNV.Interface.NhanVien;
using QLNV.Interface.Vitri;
using QLNV.Repository.Chucvu;
using QLNV.Repository.NhanVien;
using QLNV.Repository.Vitri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV
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
            services.AddMvc();

            //DI
            services.AddTransient<IDuyetNhanVienRepository, DuyetNhanVienRepository>();
            services.AddTransient<IVitriRepository, VitriRepository>();
            services.AddTransient<IChucvuRepository, ChucvuRepository>();
            services.AddTransient<ILienHeRepository, LienHeNhanVienRepository>();
            //services.AddRazorPages();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
