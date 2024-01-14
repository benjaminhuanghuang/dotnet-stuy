

IQueryable<T> interface provided by the System.Linq namespace, which can be used to create an in-memory-representation of the query that we want to execute against our database.


## Inject the DBContext into the controller
program.cs
```cs
builder.Services.AddDbContext<ApplicationDataContext>();
```
Controller
```cs
public BoardGamesController(ApplicationDbContext context, ILogger<BoardGamesController> logger){

}
```

## async
The ToArray() method that we used to retrieve the BoardGame array operates in a synchronous way: the calling thread is blocked while the SQL query is executed in the database. 


## Seeding the database
Copy bgg_dataset.csv to /Data folder

Install CsvHelper package
```
Install-Package CsvHelper
or
dotnet add package CsvHelper --version 30.0.1
```

Creating the BggRecord class
Models/Csv/BggRecord.cs

Add SeedController
Put()


## Paging
Modify RestDTO.cs
Modify BoardGamesController.cs

Access API
https://localhost:40443/BoardGames?pageIndex=0&pageSize=5


## Sort
Install package
```
Install-Package System.Linq.Dynamic.Core -Version 1.2.23
or
dotnet add package System.Linq.Dynamic.Core --version 1.2.23
```

Add parameter to BoardGamesController.Get

Access API
https://localhost:40443/BoardGames?sortColumn=Year&sortOrder=DESC


## Filter
Modify BoardGamesController.Get()


## Update
BoardGamesController.Post


## Delete
BoardGamesController.Delete
