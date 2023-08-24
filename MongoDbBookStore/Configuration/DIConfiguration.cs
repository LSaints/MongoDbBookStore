using MongoDbBookStore.Services;

namespace MongoDbBookStore.Configuration
{
    public static class DIConfiguration
    {
        public static void UseDIConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<BookServices>();
        }
    }
}
