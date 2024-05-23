using Azure.Storage.Blobs;
using Data.Contexts;
using FileProvider.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddDbContext<DataContext>(x => x.UseSqlServer(Environment.GetEnvironmentVariable("SQLSERVER")));
        services.AddScoped<BlobServiceClient>(x => new BlobServiceClient(Environment.GetEnvironmentVariable("AZURE_STORAGE_ACCOUNT")));
        services.AddScoped<FileService>();
    })
    .Build();

host.Run();
