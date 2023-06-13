# Angular 14 CRUD with .NET 6 Web API using Entity Framework Core - Full Course
https://www.youtube.com/watch?v=CdE6rVfPJ9I&t=139s



## Setup
```
ng new FullStack.UI
```

add bootstrap css and js to index.html

copy Nav code to app.component.html



## employee-list
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


## Init server side
Create project `ASP.NET Core Web API`

Add dependencies EntityFrameworkCore, EntityFrameworkCore.SqlServer and EntityFrameworkCore.Tools

Add Models\Employee.cs

Add Data\FullStackDbContext.cs

Create connection string in appsettings.json
```
```

Inject
```
builder.Services.AddDbContext<FullStackDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```
