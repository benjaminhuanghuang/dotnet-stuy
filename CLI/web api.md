- Setting up VS Code for Developing Asp.Net Core Web API
https://stackup.hashnode.dev/using-vs-code-create-aspnet-core-web-api


```bash
# create a new empty solution named stackup_vsc_setup 
dotnet new sln --name stackup_vsc_setup

dotnet new webapi --name Stackup.Api
dotnet sln add .\Stackup.Api\Stackup.Api.csproj

dotnet new nunit -n Stackup.Api.Test
dotnet dotnet sln add .\Stackup.Api.Test\Stackup.Api.Test.csproj
dotnet new nunit -n Stackup.Api.Test
dotnet dotnet sln add .\Stackup.Api.Test\Stackup.Api.Test.csproj
```

## Nuget Management
Open the command window using Cmd + Shift + P

Start typing Nuget and select the filtered command Nuget Package Manager - Add Package
