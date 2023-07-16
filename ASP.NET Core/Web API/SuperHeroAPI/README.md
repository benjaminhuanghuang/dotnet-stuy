# .NET 7 Web API & Entity Framework 🚀 Full Course (CRUD, Repository Pattern, DI, SQL Server & more)
https://youtube.com/watch?v=8pH5Lv4d5-g


Create Models


Create an API Controller - Empty


Use List<SuperHero> to tell swagger what type of data to expect from the API
```
 public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
```


## Move code from controller to service
create Services\SuperHeroService\ISuperHeroService.cs

Inject service to controller
```
// Controllers\SuperHeroController.cs
public SuperHeroController(ISuperHeroService superHeroService)
{

}


// Program.cs
builder.Services.AddSingleton<ISuperHeroService, SuperHeroService>();
```

## EE
```
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
```

Install 
```
EntityFramework
EntityFrameworkCore
EntityFrameworkCore.Design
EntityFrameworkCore.SqlServer
EntityFrameworkCore.Tools

```

Create Data\HeroDataContext.cs
configure connection string in OnConfiguring() function
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    base.OnConfiguring(optionsBuilder);

    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SuperHeroDB;Trusted_Connection=True;TrustServerCertificate=True");
}
```

Inject
```
builder.Services.AddDbContext<HeroDataContext>();
```

```
dotnet ef migrations add Initial
dotnet ef database update
```


Use dbcontext in service
```
private readonly HeroDataContext _context;

public SuperHeroService(HeroDataContext context)
{
    this._context = context;   
}
```
