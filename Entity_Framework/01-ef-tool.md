## Install EF tooling
```
  dotnet tool instal dotnet-ef

  # install globally
  dotnet tool instal dotnet-ef -g

  dotnet ef --help
```


## Build database
1. Tell EF which database will be used
```
// program.cs
service.AddDbContext<MyAppContext>(cfg =>{
    cfg.UseSqlServer
})
```

2. match the data context in project
```
    dotnet ef database update
```



```
    dotnet ef migrations add InitialDb
```