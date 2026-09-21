using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSerilog((_, configuration) => configuration.ReadFrom.Configuration(builder.Configuration));

builder.UseKernel()
    .AddGrpc(5000)
    .AddCommandSender(new Uri("http://localhost:5100/"));

var app = builder.Build();

app.Run();