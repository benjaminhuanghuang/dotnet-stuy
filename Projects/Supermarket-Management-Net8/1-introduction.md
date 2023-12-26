

## Create project
VS -> Create a new project -> ASP.NET Core Empty



## Hello world
```cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run();
```

## Process request
```cs
app.MapPost("/login", (HttpContext context) =>
{
    var username = context.Request.Form["username"];
    var password = context.Request.Form["password"];
    if (username == "frank" && password == "password") {

    }
}

void WriteHtml(HttpContext context, string html){
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context. Response.WriteAsync(html);
}
```


## Use MVC Controller
```ts
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

```


## View


## Template
Views/Shared/_Layout.cshtml
```html
  <div class="pb-3">
     @RenderSection("title", false)   // required = false
 </div>
 <div class="pb-3">
     @RenderBody()
 </div>
```

Views/Shared/_ViewStart.cshtml
```htm
@{
    Layout = "_Layout";
}
```


## CSS
Create wwwroot/lib/bootstrap/

Download bootstrap

Enable static files in Program.cs
```cs
app.UseStaticFiles();
```

Include bootstrap in _Layout.cshtml
```html
<link   >
```


## Add header into _Layout.cshtml
