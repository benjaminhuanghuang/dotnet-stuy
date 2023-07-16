Create DB in the Server Explorer in VS

Get connection str
```
appsettings.json

  "ConnectionStrings": {
    "DefautConnection": "Data Source=BENTKPAD\\SQLEXPRESS;Initial Catalog=MoviesApp-Db;Integrated Security=True;Pooling=False"
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
