
Download install package and install

```
    dotnet --list-sdks

    dotnet --version

    dotnet new --help 
```

## Create console
```
    mkdir hello
    cd hello
    dotnet new console

    dotnet add package NewtonSoft.json
    
    # download dependencies
    dotnet restore

    dotnet build

    dotnet run
```