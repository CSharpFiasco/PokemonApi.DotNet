using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using NLog.Web;
using Pokemon.Api.Configuration;
using Pokemon.Repository.Class;
using Pokemon.Repository.Context;
using Pokemon.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);
var host = builder.Host;
var services = builder.Services;
var configuration = builder.Configuration;

// Add logging
host.UseNLog();

// Add services to the container.
services.AddDbContext<PokemonDatabaseContext>(opts =>
{
    opts.UseSqlServer(configuration.GetConnectionString("PokemonDatabase"));
});

services.AddScoped<IPokemonRepository, PokemonRepository>();
services.AddScoped<IMoveRepository, MoveRepository>();

IEdmModel model = EdmModelConfiguration.GetEdmModel();

services.AddControllers().AddOData(options => {
    options.EnableQueryFeatures(100).AddRouteComponents("v1", model);
    options.RouteOptions.EnableKeyAsSegment = false;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Pokemon API", Version = "v1" });
});

var app = builder.Build();
var environment = app.Environment;

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (environment.IsDevelopment())
{
    app.UseODataRouteDebug();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
