## create Application DbContext
```
public class DutchContext : DbContext
{

private readonly IConfiguration _config;

public DutchContext(IConfiguration config ) 
{
    _config = config;
}


public DbSet<Product> Products { get; set; }
public DbSet<Order> Orders { get; set; }

```

