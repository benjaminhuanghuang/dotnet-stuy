
Everything related to business and business services will go in application layer

## Dashboard Service


## Update DashboardController.cs



## IDbInitializer
Inject
```cs   
builder.Services.AddScoped<IDashboardService, DashboardService>();
```

Move code from AccountController.cs to DbInitializer.cs
```cs
if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
{
    _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).Wait();
    _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).Wait();
}
```


Call SeedData() in Program.cs
```cs
builder.Services.AddScoped<IDbInitializer, DbInitializer>();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();
    }
}
``` 
