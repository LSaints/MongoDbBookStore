using MongoDbBookStore.Models;

namespace MongoDbBookStore.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void UseDatabaseConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.Configure<BookStoreDatabaseSettings>(
                builder.Configuration.GetSection("BookStoreDatabase"));
        }
    }
}
