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



## Role & register
```cs
// create roles in DB
 if (!_roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
 {
     _roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
     _roleManager.CreateAsync(new IdentityRole("Customer")).Wait();
 }
```


## Authorization with Roles
```
    [Authorize(Roles = SD.Role_Admin)]  // access denied if not admin


    [Authorize]
```

Config the controllers of auth
```
builder.Services.ConfigureApplicationCookie(option =>
    {
    option AccessDeniedPath = "/Account/AccessDenied";
    option. LoginPath = "/Account/Login";
    });
```

Config the Identity in Startup.cs
```
builder.Services.Configure<IdentityOptions>(option =>
    option.Password.RequiredLength = 6;
    pption. Password. RequireDigit = false;
    });
```

## The return URL
Login.cshtml
```
    <input asp-for="RedirectUrl" hidden />

    <a asp-action="Register" asp-route-returnUrl="@Model.RedirectUrl">Register as a new user</a>
```
