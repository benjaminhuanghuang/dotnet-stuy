# .NET MAUI Step by Step Build
https://www.youtube.com/watch?v=LrZwd-f0M4I&ab_channel=LesJackson

https://github.com/binarythistle/S05E04---.NET-MAUI-Step-by-step-

## Server Side
### Create project
Create 'ASP.NET Core Web API'

Uncheck 'Use controllers'
Uncheck 'Enable OpenAPI support'

### Install packages
```
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Design
```

### Create database
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

Run command in terminal under project folder
``` 
    // install ef tools
    dotnet tool install --global dotnet-ef
    dotnet tool update --global dotnet-ef

    // create migration
    dotnet ef migrations add init

    // create database
    dotnet ef database update
```


### URL
```
    https://localhost:5225/api/todo
```


## Client side
### Create project
.NET MAUI App

