


```
// AppContext

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Product>()
    .Property(p => p.Price)
    .HasColumnType("money");

    modelBuilder.Entity<OrderItem>()
    .Property(o => o.UnitPrice)
    .HasColumnType("money");

    modelBuilder.Entity<Order>()
    .HasData(new Order()
    {
        Id = 1,
        OrderDate = DateTime.UtcNow,
        OrderNumber = "12345"
    });
}
```


```
    dotnet ef migrations add SeedData
```


DutchSeeder.cs
```
```
