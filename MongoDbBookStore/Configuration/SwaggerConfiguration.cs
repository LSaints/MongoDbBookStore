namespace MongoDbBookStore.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void UseSwaggerConfiguration(this IApplicationBuilder appBuilder)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                appBuilder.UseSwagger();
                appBuilder.UseSwaggerUI();
            }
        }
    }
}
