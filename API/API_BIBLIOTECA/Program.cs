using LIVROAPI.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGetRoutes();

app.Run();
