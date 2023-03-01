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

### Models

### DataServices

Register DataServices for dependency injection
```
builder.Services.AddSingleton<IRestDataService, RestDataService>();
```
### Install
```
    Microsoft.Extensions.Http
```
## Setup for Android
Tools > Android > Android Device Manager

Windows Developer settings > Enable 'Developer Mode'

Run > Android Emulators > 

Create Platform/Android/Resources/xml/network_security_config.xml
```
<?xml version="1.0" encoding="utf-8"?>
<network-security-config>
	<domain-config cleartextTrafficPermitted="true">
		<domain includeSubdomains="true">10.0.2.2</domain>
	</domain-config>
</network-security-config>
```

Modify \Platforms\Android\AndroidManifest.xml
```
<application android:networkSecurityConfig="@xml/network_security_config" android:allowBackup="true" android:icon="@mipmap/appicon" android:roundIcon="@mipmap/appicon_round" android:supportsRtl="true"></application>
```