OpenApi 是一种和语言无关的用于描述REST APIs 接口功能的一种规范，对REST APIs 接口的描述包括： 接口参数信息、接口返回值信息、api 功能描述、请求路径等。

Swagger 就是其中一个实现了Open Api 规范的工具。

.NET 中REST APIs的代表是 web api. .net 针对Web Api 也有相应的Swagger 实现，主要有：Swashbuckle 和 NSwag




Install package Swashbuckle.AspNetCore in the ASP.NET Core Web API project
```
Install-Package Swashbuckle.AspNetCore
```
or
Right-click the project in Solution Explorer > Manage NuGet Packages


Add and configure Swagger middleware
Inject API service into the container

```
    services.AddControllersWithViews();
    services.AddSwaggerGen();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

```

To serve the Swagger UI at the app's root (https://localhost:<port>/), set the RoutePrefix property to an empty string:

```
app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
```


Config the URL of the OpenApi Json
```
```


Profile in launchSettings.json0
```
    "FullStack.API": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7001;http://localhost:5133",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
```
