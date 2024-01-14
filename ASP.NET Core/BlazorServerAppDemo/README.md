# Full C# Project: Supermarket Management System | ASP.NET Core Blazor, EF Core, SQL Server, Identity
https://www.youtube.com/watch?v=DWrH7br4DsM

## Design
- Admins:
Manage Categories
Manage Products
Manage Sellers

- Sellers
Cashier Console


## Create project
Blazor Server App
Solution name: SupermarketManagementSystem
Project name: WebApp

Add new project
Class Library
Project name: UseCases

Add new project
Class Library
Project name: CoreBusiness

Add new project
Class Library
Project name: Plugins.DataStore.InMemory
We are creating a InMemory data store first for rapid development, then swap it with SQL database later.


Dependency injection
```
// Dependency injection for In-Memory data store
builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
// Dependency injection for Use cases
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();

```

Add Razor component under Pages folder

Add dependencies into _imports
```
@using CoreBusiness
```
## CategoriesComponent.razor
add link in the Shared/NavMenu.razor

## AddCategoryComponent.razor


## GetCategoryById and EditCategory 

## Delete
DeleteCategoryUseCase


## Products
ViewProductsUseCase

add link in the Shared/NavMenu.razor


## Add Product
AddProductUseCase
IAddProductUseCase

inject
```
builder.Services.AddTransient<IAddProductsUseCase, AddProductsUseCase>();
```

AddProductComponent.razor


## Edit Product
EditProductUseCase
IEditProductUseCase

inject

EditProductComponent.razor


## Delete Product
DeleteProductUseCase
IDeleteProductUseCase


## Cashier Console
ViewProductsByCategoryId

SelectProductForSellingComponent.razor

CashierConsoleComponent.razor


## Sell Product


## List sold items
Transaction

RecordTransactionUseCase

IGetTodayTransactionsUseCase, GetTodayTransactionsUseCase



## Transaction report
GetTransactionUseCase

TransactionReportComponent.razor

Nav link


## Printing
```
@media print {
    body * {
        visibility: hidden;
    }

    #printarea, #printarea * {
        visibility: visible;
    }

    #printarea {
        position: absolute;
        left: 0;
        top: 0;
    }
}
```

## SQL & Entity Framework
Create new project Plugins.DataStore.SQL

Add dependencies
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer   // for WebApp and Plugins.DataStore.SQL
Microsoft.EntityFrameworkCore.Tools   // for WebApp and Plugins.DataStore.SQL

```

Add MarketContext



Open Server Explorer, add data connection, copy the connection string to appsettings.json

```
builder.Services.AddDbContext<MarketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

Add migration:
Tools -> NuGet Package Manager -> Package Manager Console
Default project: Plugins.DataStore.SQL
```
Add-Migration Init
Update-Database
```

## Identity & Auth
Project -> Add new scaffolded -> Identity -> Account/Login, Account/Logout, Account/Register


Tools -> NuGet Package Manager -> Package Manager Console
```
Add-Migration CreateIdentitySchema -Context AccountContext

Update-Database -Context AccountContext
```
