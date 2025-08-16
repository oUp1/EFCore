using EFCore;
using EFCore.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration((hostingContext, configuration) =>
{
    configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddEnvironmentVariables();

}).ConfigureServices((hostContext, services) =>
{
    services.AddDbContext<DataContext>();
    services.AddHostedService<Worker>();
});

var host = builder.Build();
await host.RunAsync();