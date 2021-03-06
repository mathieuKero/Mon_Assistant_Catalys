using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.BotFramework;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using TestBot.Bots;
using TestBot.Middleware;

namespace TestBot
{
    public class Startup
    {
        // Inject the IHostingEnvironment into constructor
        public Startup(IWebHostEnvironment env)
        {
            // Set the root path
            ContentRootPath = env.ContentRootPath;
        }

        // Track the root path so that it can be used to setup the app configuration
        public string ContentRootPath { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Set up the service configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            var configuration = builder.Build();
            services.AddSingleton(configuration);

            // Add your SimpleBot to your application
            services.AddBot<SimpleBot>(options =>
            {
                options.CredentialProvider = new ConfigurationCredentialProvider(configuration);

                options.Middleware.Add(new SimpleMiddleware1());
                options.Middleware.Add(new SimpleMiddleware2());
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            // Tell your application to use Bot Framework
            app.UseBotFramework();
        }
    }
}
