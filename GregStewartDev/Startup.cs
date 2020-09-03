using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure;
using Application;
using System;
using Application.Interfaces;
using WebUI.Services;

namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            Uri baseAddressUri = new Uri("http://localhost:5000/api/");

            services.AddControllers();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddInfrastructure();
            services.AddApplication();

            RegisterTypedClient<IBlogPostService, BlogPostService>(services, baseAddressUri);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private void RegisterTypedClient<TClient, TImplementation>(IServiceCollection services, Uri apiBaseUri)
            where TClient : class where TImplementation : class, TClient
        {
            services.AddHttpClient<TClient, TImplementation>(client =>
            {
                client.BaseAddress = apiBaseUri;
            });
        }
    }
}
