1. connection string

appsettings.Development.json
```
    "ConnectionStrings": {
        "DefaultConnection": "Server=.\\SQLEXPRESS;Database=Abby;Trusted_Connection=True;TrustServerCertificate=True"
    }
```


2. Program.cs
```
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
```

3. Model
```
     public class Category
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        public int DisplayOrder { get; set; }
    }
```

4. ApplicationDbContext.cs
```
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // Data table
    public DbSet<Category> Category { get; set; }  
}
```

5. Run migration
Install Microsoft.EntityFrameworkCore.Tools

Tools -> NuGet Package Manager -> Package Manager Console
```
PM> add-migration AddCategoryToDb
```



