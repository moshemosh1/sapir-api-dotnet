using Sapir_API_dotnet.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Sapir_API_dotnet.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDataBaseSettings>(builder.Configuration.GetSection(nameof(MongoDataBaseSettings)));
builder.Services.AddSingleton<IMongoDataBaseSettings>(sp => sp.GetRequiredService<IOptions<MongoDataBaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("MongoDataBaseSettings:ConnectionString")));

builder.Services.AddScoped<IPersonService, PersonService>();

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
