
using AdventurersAlmanac.Domain.Contracts;

var bld = WebApplication.CreateBuilder(args);

bld.Services
   .AddFastEndpoints()
   .SwaggerDocument(o =>
{
    o.DocumentSettings = s =>
    {
        s.Title = "Adventurer's Almanac API";
        s.Version = "v1";
    };
});

bld.Services.AddScoped<IProfileRepository, ProfileRepository>();
bld.Services.AddScoped<IProfileDataProvider, ProfileDataProvider>();


var app = bld.Build();

app.UseFastEndpoints()
   .UseSwaggerGen();

app.Run();

public partial class Program { }