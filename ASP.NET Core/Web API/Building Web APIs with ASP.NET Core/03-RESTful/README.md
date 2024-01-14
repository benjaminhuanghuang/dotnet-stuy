
## CORS
The purpose of CORS is to allow browsers to access resources by using HTTP requests initiated from scripts (such as XMLHttpRequest and Fetch API) when those resources are located in domains other than the one hosting the script. 

In the absence of such a mechanism, browsers would block these “external” requests because they would break the same-origin policy, which allows them only when the protocol, port (if specified), and host values are the same for both the page hosting the script and the requested resource.

If we want the browser to perform that call, we can use CORS to instruct it to relax the policy and allow HTTP requests from external origins.
CORS is handled by checking the Access-Control-Allow-Origin header and ensuring that it complies with the origin of the script that issued the call.
The browser checks the preflight request’s response values to determine whether to issue the subsequent HTTP request.
```cs
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(cfg => {
        cfg.AllowAnyOrigin();
        cfg.AllowAnyHeader();
        cfg.AllowAnyMethod();
    }));

```
appSettings.json
```json
 "AllowedOrigins": "*",
```

program.cs
```cs
// Minimal API
app.MapGet("/error", [EnableCors("AnyOrigin")] () =>
    Results.Problem());
```


## DTO
DTOs are POCO classes that can be used to expose relevant info about that object only to the requesting client. 
