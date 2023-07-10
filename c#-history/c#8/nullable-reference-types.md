# Nullable reference types (C# reference)
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types


Nullable reference types is introduced in C# 8.0 that enhances code safety and reduces the likelihood of null reference exceptions. 
It allows developers to annotate their reference types to explicitly indicate whether they can be assigned null values or not.

By default, reference types in C# are nullable, meaning they can hold null values. This flexibility, while convenient, can `lead to runtime null reference exceptions` that can be difficult to debug. Nullable reference types address this issue by introducing compile-time checks to detect possible null references, helping catch potential issues early in the development process.

To enable nullable reference types in your C# project, you need to set the nullable context option either in your project file or using compiler flags. Once enabled, you can start annotating your reference types using nullable annotations.

## Enable the nullable context in the project file
```
  <Nullable>enable</Nullable>
```
Note: All project templates starting with .NET 6 (C# 10) enable the nullable context for the project. 
