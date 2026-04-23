/*
 * dependencies problem
 * file wird isoliert ausgefuehrt und findet webapplication nicht
 * ueber terminal ins API Verzeichnis und mit dotnet run ausfuehren --> so wird die csproj beachtet
 * 
 */
var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddControllers(); // um controller zu verwenden
builder.Services.AddEndpointsApiExplorer(); //endpoints fuer swagger
builder.Services.AddSwaggerGen(); //swagger aktivieren 

var app = builder.Build(); //anwendung bauen 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); //https umleitung 

app.MapControllers(); //macht alle controller erreichbar 
app.MapGet("/", () => "API läuft");
app.Run();