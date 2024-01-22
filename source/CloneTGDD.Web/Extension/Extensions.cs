using CloneTGDD.Web.Services;
using Microsoft.FluentUI.AspNetCore.Components;

namespace CloneTGDD.Web.Extension
{
    public static class Extensions
    {
        public static void AddApplicationExtensionServices(this IHostApplicationBuilder builder)
        {
            // HTTP client registrations     
            builder.Services.AddHttpClient<ProductsApiClient>(o => o.BaseAddress = new("http://productsapi"));
            builder.Services.AddHttpClient<UserAuthApiClient>(o => o.BaseAddress = new("http://userauthapi"));
            
            // Add services to the container.
            builder.AddRedisOutputCache("cache");

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddHttpClient();
            builder.Services.AddFluentUIComponents();

            builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
        }
    }
}
