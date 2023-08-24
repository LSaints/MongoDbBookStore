namespace MongoDbBookStore.Configuration
{
    public static class ControllerConfiguration
    {
        public static void UseControllerConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
        }
    }
}
