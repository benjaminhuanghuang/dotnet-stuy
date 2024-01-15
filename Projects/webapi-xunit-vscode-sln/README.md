## Setup
```bash
dotnet new sln -n webapi-xunit-vscode-sln

# 
dotnet new webapi -o webApi     
dotnet sln add webApi      


dotnet new xunit -o webApi.Tests
dotnet sln add webApi.Tests/webApi.Tests.csproj

dotnet add ./webApi.Tests/webApi.Tests.csproj reference ./webApi/webApi.csproj

```


## Run 
```bash
    dotnet run --project webApi/webApi.csproj
```

## Run Test
```bash
    dotnet test
    
    dotnet test webApi.Tests/webApi.Tests.csproj
```
