using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Surveymatic.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.Cookies;
using Surveymatic.Services;
using Blazored.LocalStorage;
using Surveymatic.Model;
using Surveymatic.Model.LoginData;
namespace Surveymatic
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
            services.AddRazorPages();

            services.AddDbContextFactory<SurveymaticContext>(options =>
            {
                options.LogTo(Console.WriteLine); // MariaDB / EFCore Debugging
                options.UseMySql(
                    Configuration.GetConnectionString("SurveyMaticContext"),
                    new MySqlServerVersion(Configuration.GetValue<string>("MariaDbVersion"))
                );
            });

            services.AddBlazoredLocalStorage();
            services.AddServerSideBlazor();


            services.AddScoped<SiteUser>();
            services.AddScoped<RegistrationForm>();
            services.AddScoped<LoginForm>();
            services.AddScoped<ForgotPassForm>();
            services.AddScoped<ResetPassForm>();
            services.AddScoped<PasswordChange>();
            services.AddServerSideBlazor();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddHttpContextAccessor();
            services.AddSingleton<SurveyService>();
            services.AddScoped<ISessionService, Session>();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}