```bash
dotnet new mstest -o StringLibraryTest

# Add the test project to the solution.
dotnet sln add StringLibraryTest/StringLibraryTest.csproj

# add a reference in the StringLibraryTest project to the StringLibrary project
dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj



# Run test
dotnet test StringLibraryTest/StringLibraryTest.csproj
# - Run the tests with the Release build configuration
dotnet test StringLibraryTest/StringLibraryTest.csproj --configuration Release
```
