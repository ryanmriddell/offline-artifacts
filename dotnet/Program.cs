var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(8080);
});

var app = builder.Build();

app.MapGet("/", () =>
{
    return "{ \"test\": \"success\" }";
});

app.Run();
