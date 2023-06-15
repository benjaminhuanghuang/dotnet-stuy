# Angular 14 CRUD with .NET 6 Web API using Entity Framework Core - Full Course
https://www.youtube.com/watch?v=CdE6rVfPJ9I&t=139s



## Setup angular project
```
ng new FullStack.UI
```

add bootstrap css and js to index.html

copy Nav code to app.component.html



## Create employee-list component/page
Create component
```
    ng g c employee-list
```

Add employee-list component to app-routing.module.ts
```
    const routes: Routes = [
        {
            path: 'employees', component: EmployeeListComponent
        }
    ];
``` 

Add routerLink to the path in the nav bar
```
    <a class="nav-link active" aria-current="page" routerLink="employees">Employees</a>
    
```
Create employee.model.ts

Use Employee in employee-list component 

Add table in employee-list.component.html


## Init server side Web API project
Create project `ASP.NET Core Web API`

Add dependencies EntityFrameworkCore, EntityFrameworkCore.SqlServer and EntityFrameworkCore.Tools

Add Models\Employee.cs

Add Data\FullStackDbContext.cs

Create connection string in appsettings.json
```
    "FullStackConnectionString": "server=BenTKPAD\\SQLEXPRESS;database=FullStackDb; Trusted_Connection=true;TrustServerCertificate=True"
```

Inject
```
builder.Services.AddDbContext<FullStackDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

Create database
Tools -> NuGet Package Manager -> Package Manager Console
```
Add-Migration "Initial Migration"

Update-Database
```


Add controller `EmployeesController`

## Swagger
Install package Swashbuckle.AspNetCore

Use Swagger in the Program.cs
```

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c=>
{
	c.SwaggerDoc("v1", new() { Title = "FullStack.API", Version = "v1" });
});


if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

```
