# .NET MAUI Step by Step Build
https://www.youtube.com/watch?v=LrZwd-f0M4I&ab_channel=LesJackson

https://github.com/binarythistle/S05E04---.NET-MAUI-Step-by-step-

## Server Side
### Create project
Create 'ASP.NET Core Web API'

Uncheck 'Use controllers'
Uncheck 'Enable OpenAPI support'

## Install packages
```
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Design
```

## Create database
connect string
```
// appsettings.Development.json
SqliteConnection": "Data Source=ToDo.db"
```

connect to db
```
// Program.cs
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
```
