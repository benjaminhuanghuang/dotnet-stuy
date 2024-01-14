## SQL vs Non-SQL


## Setting up SQL Server

## Setting up EF Core
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.11
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.11


# a set of command-line features that we can use to perform design-time development tasks
dotnet tool install --global dotnet-ef --version 6.0.11
```
Or
Right click on the project Dependencies -> Manage NuGet Packages
Install
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer   // for WebApp and Plugins.DataStore.SQL
Microsoft.EntityFrameworkCore.Tools       // the Package Manager Console commands


## DbContext
program.cs
```
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
    );    
```

## Code first vs Database first

## Navigation properties
In EF Core, the term navigation property describes an entity property that directly references a single related entity or a collection of entities

Overwriting the ApplicationDbContext.OnModelCreating


## DbSets
In EF Core, entity types can be made available through the DbContext by using a container class known as DbSet
```cs
public DbSet<BoardGame> BoardGames => Set<BoardGame>();
```


## Setting up the DbContext
right-click to the project’s root folder in Solution Explorer and then choose the Manage User Secrets option
secret.json
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=MyBGList;
        User Id=MyBGList;Password=MyS3cretP4$$;
        Integrated Security=False;MultipleActiveResultSets=True;
        TrustServerCertificate=True"
  }
}

or
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS; Database=MyBGList;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True"
  }
}
```
All the key/value pairs that we put in the secrets.json file override the corresponding key/value pairs in any appsettings*.json file

## Secrets

All the key/value pairs that we put in the secrets.json file override the corresponding key/value pairs in any appsettings*.json file


## Creating the database
```
dotnet ef migrations add Initial

dotnet ef database update Initial
```

Or In visual studio Tools -> NuGet Package Manager -> Package Manager Console
Switch the Default project if necessary
```
Add-Migration Init
Update-Database
```
