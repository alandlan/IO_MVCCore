using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using static DevIO.UI.Site.Data.PedidoRepository;
using DevIO.UI.Site.Data;

namespace DevIO.UI.Site
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add(item: "/Modulos/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add(item: "/Modulos/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add(item: "/Views/Shared/{0}.cshtml");
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IPedidoRepository, PedidoRepository>();
            //services.AddTransient<PedidoRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",template: "{controller=Home}/{action=Index}/{id?}");
                //routes.MapRoute(name: "areas",template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapAreaRoute(name: "AreaProdutos", areaName: "Produtos", template: "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
                routes.MapAreaRoute(name: "AreaVendas", areaName: "Vendas", template: "Vendas/{controller=Pedidos}/{action=Index}/{id?}");

            });
        }
    }
}
