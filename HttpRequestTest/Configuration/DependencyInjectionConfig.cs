using HttpRequestExamples.Repositories;

namespace HttpRequestExamples.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<Interfaces.IHttpClientFactory, HttpClientFactory>();
            services.AddHttpClient();

            return services;
        }
    }
}