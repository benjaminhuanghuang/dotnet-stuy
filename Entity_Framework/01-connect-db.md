Create DB in the Server Explorer in VS

Get connection str
```
appsettings.json

  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS; Database=WhiteLagoon;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True"
  }
```



## Use OnConfiguring in the DbContext class
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    base.OnConfiguring(optionsBuilder);

    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SuperHeroDB;Trusted_Connection=True;TrustServerCertificate=True");
}

```
