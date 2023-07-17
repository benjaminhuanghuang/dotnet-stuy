# CRUD with Angular 14 & .NET 6 🚀 Web API, EF Core & SQL Server
https://www.youtube.com/watch?v=dtthbiP3SE0&t=5s


## Client 
```
ng new SuperHero.UI
routing: yes
css
```

Create models\super-hero.ts


Create service
```
 ng g s super-hero --skip-tests
```


Add apiUrl to environment.ts
```
export const environment = {
  production: false,
  apiUrl: 'https://localhost:44379/api'
};
```


## Server
Create project ASP.NET Core Web API




## EF
install
```
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design

```


Add DataContext



Add ConnectionString to appsettings.json
```
 "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=SuperHeroDB;Trusted_Connection=True;TrustServerCertificate=True"
  }
```

Using connection string in Startup.cs
```
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
```
