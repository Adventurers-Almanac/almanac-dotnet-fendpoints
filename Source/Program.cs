using FastEndpoints;
using FastEndpoints.Security;

var bld = WebApplication.CreateBuilder(args);
bld.Services
   .AddFastEndpoints()
   .SwaggerDocument();

var app = bld.Build();

app.UseAuthentication()
   .UseAuthorization()
   .UseSwaggerGen();

app.Run();

public partial class Program { }