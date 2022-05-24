using Blazorise;

namespace BlazoriseTopHeaderSample
{
    public static class Config
    {
        public static IServiceCollection SetupBlazorise(this IServiceCollection services)
        {
            services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                });

            return services;
        }
    }
}
