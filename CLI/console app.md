
```bash
dotnet new console -o hello

dotnet run
```


## Create project

```bash
    # -o or --output as the switch to specify the folder and project name
    dotnet new console --output HelloCS
    dotnet new console -o HelloCS

    ## -f or --framework switch to specify a target framework
    dotnet new console -f net6.0

    ## do not use top-level program
    dotnet new console -o AboutMyEnvironment --use-program-main
```

Add project to solution
```bash
    dotnet sln add HelloCS
``` 
