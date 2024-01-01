## Add Identity
Use IdentityDbContext

Install 
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNet.Identity.EntityFramework


Config Identity in Program.cs


## Create Identity Tables
```
add-migration AddIdentityToDb

update-database
```

## Add properties to IdentityUser
Add fields to ApplicationUser

```
add-migration AddPropertiesToUserTable
update-database
```


## Login



## Role 
```cs
// create roles in DB
 if (!_roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
 {
     _roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
     _roleManager.CreateAsync(new IdentityRole("Customer")).Wait();
 }
```
