
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Dependency injection
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer();
builder.Services.AddAuthorization();


var app = builder.Build();

// Middleware pipeline
app.UseAuthentication();
app.UseAuthorization();


app.MapGet("/", [Authorize] () =>
{
    return "Hello!";
});


app.Run();