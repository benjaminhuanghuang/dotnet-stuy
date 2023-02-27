## Startup.cs
.NET 6 eliminate the startup.cs from all web projects

Change Host to WebApplication



.NET 5
```
// Program.cs
public class Program {
    public static void Main(string[] args) {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) => 
        Host.CreateDefaultBuilder(args).
            .ConfigureWebHostDefaults(webBuilder => {
                webBuilder.UseStartup<Startup>();   // bring the startup class to some configuration
            })
}



// Startup.cs
public void ConfigureServices(IServiceCollection services) {
    service.AddControllersWithViews();
}

public void Config(IApplicationBuilder app, IWebHostEnvironment env) {
    if (env.IsDevelopment()){

    }
}


```


.NET 6
```
// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Service.AddControllersWithViews()



var app = builder.Build();

if (!app.Environment.IsDevelopment()) {

}

app.Run();
```
