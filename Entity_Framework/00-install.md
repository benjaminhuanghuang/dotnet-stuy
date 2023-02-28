## Install Entity Framework
Tools > NuGet Package Manager > 
or 
Project > Dependencies > Manage NuGet Packages


Install packages
```
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.EntityFrameworkCore.Design
```



## Install EF tooling
```
  # install globally
  dotnet tool install dotnet-ef -g
  or
  dotnet tool install --global dotnet-ef
  
  # update
  dotnet tool update --global dotnet-ef

  
  dotnet ef --help
```