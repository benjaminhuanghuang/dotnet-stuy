```bash
cd classlib-xunit-vscode-cln
dotnet new sln -n classlib-xunit-vscode-cln

dotnet new classlib -o Utils
ren .\Utils\Class1.cs PrimeService.cs
dotnet sln add ./Utils/Utils.csproj

dotnet new xunit -o Utils.Tests
dotnet add ./Utils.Tests/Utils.Tests.csproj reference ./Utils/Utils.csproj
dotnet sln add ./Utils.Tests/Utils.Tests.csproj
```
