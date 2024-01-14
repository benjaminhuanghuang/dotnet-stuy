## Create project
Project templated: ASP.NET Core Web API


## launchSettings.json
Change the port

## appsettings.json
```json
"UseDeveloperExceptionPage": false

```


```cs
if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
    app.UseDeveloperExceptionPage();
else
    app.UseExceptionHandler("/error");
```

##  Program.cs 
```csharp

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // captures synchronous and asynchronous exceptions from the HTTP pipeline and generates an HTML error page (the developer exception page)
    app.UseDeveloperExceptionPage();
}
else
{
    // handles HTTP-level exceptions and sends all the relevant error info to a customizable handler
    app.UseExceptionHandler("/error");
}

```

## Controller vs Minimal API
```csharp

[Route("/error")]
[HttpGet]
public IActionResult Error()
{
    return Problem();
}


app.MapGet("/error/test", () => { throw new Exception("test"); });

```


## Router
Telling Swagger to resolve all conflicts related to duplicate routing handlers by always taking the first one found and ignoring the others.

```cs
builder.Services.AddSwaggerGen(opts =>
    opts.ResolveConflictingActions(apiDesc =>  apiDesc.First())
    );
```
