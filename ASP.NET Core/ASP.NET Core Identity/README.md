


1. Installing the NuGet packages
- Microsoft.Extensions.Identity.Core, containing the membership system and the main classes and services to handle the various login features we need

- Microsoft.AspNetCore.Identity.EntityFrameworkCore, the ASP.NET Core Identity provider for EF Core

- Microsoft.AspNetCore.Authentication.JwtBearer, containing middleware that enables ASP.NET Core applications to handle JSON Web Tokens (JWTs)

2. Create a new User entity class to handle user data such as username and password


3. Update our existing ApplicationDbContext to enable it to deal with the new user entity

4. Data base migration and update

5. Set up and configure the required identity services and middleware in the Program.cs
   
6.  new controller to handle the registration and login
