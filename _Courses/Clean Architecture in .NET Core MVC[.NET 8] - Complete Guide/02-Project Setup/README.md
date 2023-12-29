## Create Project
ASP.NET Core Web App (Model-View-Controller)


## Create Class Library Project
- WhiteLagoon.Domain
- WhiteLagoon.Application
- WhiteLagoon.Infrastructure


## Create entities in the Domain project


## Config the Entity Framework Core
Add NuGet Packages:

- WhiteLagoon.Web
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design

- WhiteLagoon.Infrastructure
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.EntityFrameworkCore.Design


Create Db context


Add connection string in appsettings.json (Move to secret vault in production)
```
 "ConnectionStrings": {
   "DefaultConnection": "Server=.\\SQLEXPRESS; Database=WhiteLagoon;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True"
 }
```


Register DbContext in Program.cs
```
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```


Create database
Tools -> NuGet Package Manager -> Package Manager Console
PM> update-database


Create table class
```cs
  public DbSet<Villa> Villas { get; set; }
```
Add table to db, Switch project to Infrastructure in Package Manager Console and run
```
PM> add-migration AddVillaToDb    # create migration file
PM> update-database
```

Seed Data
```cs
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      base.OnModelCreating(modelBuilder);
  }

```
```
PM> add-migration seedVillaToDb    # create migration file
PM> update-database
```
