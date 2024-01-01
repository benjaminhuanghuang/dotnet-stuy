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
