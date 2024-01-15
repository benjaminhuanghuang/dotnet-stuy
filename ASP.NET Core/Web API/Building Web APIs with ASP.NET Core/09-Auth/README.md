
## Authentication
Authentication is a mechanism to verify that an entity (or a person) is what it claims (or they claim) to be.
Who?

## Authorization
Permission check?


## Implementation methods
- Session/cookies
- Bearers token
- API Keys
- Signatures and certificates
  

## ASP.NET Core Identity
Install
Microsoft.Extensions.Identity.Core
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Authentication.JwtBearer

## Creating the user entity

```cs
builder.Services.AddIdentity<ApiUser, IdentityRole>(options =>         
{
    options.Password.RequireDigit = true;                              
    options.Password.RequireLowercase = true;                          
    options.Password.RequireUppercase = true;                          
    options.Password.RequireNonAlphanumeric = true;                    
    options.Password.RequiredLength = 12;                              
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
```
## Create a new User entity class to handle user data such as username and password


## Update our existing ApplicationDbContext to enable it to deal with the new user entity

## Data base migration and update

## Set up and configure the required identity services and middleware in the Program.cs
   
6.  new controller to handle the registration and login
