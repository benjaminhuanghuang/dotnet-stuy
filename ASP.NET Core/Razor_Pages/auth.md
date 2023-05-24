


```
    [Authorize]
    //[Authorize(Roles = "Admin,Admin1,Admin2")]
    //[Authorize(Roles = "Manager")]
    [Authorize(Policy = "GraduatedOnly")]
    public class AddMovieModel : PageModel
    {

    }
```


```
// Program.cs
// Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/Login";
        options.AccessDeniedPath = "/Denied";
    });
```