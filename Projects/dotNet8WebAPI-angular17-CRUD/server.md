## .NET 8 Web API

```bash

dotnet new webapi -o API


dotnet watch run

```

## Data model

Create Models/Student.cs

Create Data/AppDbContext.cs
Inject DbContext into Program.cs
```cs
builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")
));
```

Install Entity Framework Core
ctrl+shift+p > Open NuGet Gallery
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Sqlite

update appsettings.json
```json
"ConnectionStrings": {
    "DefaultConnection": "Data Source=student.db"
}
```

## Add controller StudentController
Add controller in the program.cs
```cs
builder.Services.AddControllers();
...
app.mapControllers();


```


## Add migration

```
dotnet tool install --global dotnet-ef

dotnet ef migrations add Initial
dotnet ef database update
```

## Open Sqlite
Install Sqlite extension in VSCode
ctrl+shift+p > Open Sqlite


## CRUD API
