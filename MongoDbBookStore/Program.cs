using MongoDbBookStore.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.UseControllerConfiguration();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.UseDatabaseConfiguration(builder);
builder.Services.UseDIConfiguration();

var app = builder.Build();

app.UseSwaggerConfiguration();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
