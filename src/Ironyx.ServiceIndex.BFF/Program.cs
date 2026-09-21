using Ironyx.ServiceIndex.BFF.Application;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSerilog((_, configuration) => configuration.ReadFrom.Configuration(builder.Configuration));

builder.UseKernel()
    .AddGrpc(5000)
    .AddCommandSender(new Uri("http://localhost:5900/"));

builder.Services.AddControllers();

builder.Services.AddTransient<IServiceIndexClient, ServiceIndexClient>();

var app = builder.Build();

app.MapControllers();

app.Run();