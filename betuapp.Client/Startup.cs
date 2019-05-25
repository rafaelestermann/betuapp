using betuapp.Client.Services.Contracts;
using betuapp.Client.Services.Implementations;
using betuapp.Client.States;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace betuapp.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<AuthenticationState>();
            services.AddScoped<DetailState>();
            services.AddScoped<IAuthorizeApi, AuthorizeAPI>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
                        app.AddComponent<App>("app");
        }
    }
}
