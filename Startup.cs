using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging;
using Serilog.Extensions.Logging.File;

namespace WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configura i servizi di cui hai bisogno per l'applicazione
            // Ad esempio, aggiungi i servizi MVC, EF Core, etc.

            //Logging   

            services.AddMvc();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                //AddFile viene aggiunto una volta inserita la libreria di Serilog
                loggingBuilder.AddFile("Logs/log-app-{Date}.txt");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configura l'applicazione
            // Ad esempio, aggiungi middleware, routing, etc.

            var logger = app.ApplicationServices.GetRequiredService<ILogger<Startup>>();
            logger.LogInformation("Esempio di log di informazioni");

            app.UseRouting();

            //Sono in ambiente di sviluppo  
            if(env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

//Sono in produzione
            if(env.IsEnvironment("Production"))
            {
                app.UseHttpsRedirection();
            }

            //MiddleWare per l'utilizzo dei file statici
            app.UseStaticFiles();


            //app.UseMvcWithDefaultRoute();

            //Gestione EndPoints da AspNet 3
            //Template di default
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}