# Understanding Nullable Reference Types in C#
https://dev.to/hootanht/understanding-nullable-reference-types-in-c-3d13

Nullable reference types is introduced in C# 8.0 that enhances code safety and reduces the likelihood of null reference exceptions. 
It allows developers to annotate their reference types to explicitly indicate whether they can be assigned null values or not.

By default, reference types in C# are nullable, meaning they can hold null values. This flexibility, while convenient, can lead to runtime null reference exceptions that can be difficult to debug. Nullable reference types address this issue by introducing compile-time checks to detect possible null references, helping catch potential issues early in the development process.


To enable nullable reference types in your C# project, you need to set the nullable context option either in your `project file` or `using compiler flags`. Once enabled, you can start annotating your reference types using nullable annotations.


## nullable annotations
- Non-nullable types: string! 
These types cannot be assigned null values. If a null value is assigned to a non-nullable type, a compiler warning will be generated.

- Nullable types: string?
These types can be assigned null values. When working with nullable types, the developer is required to handle potential null values explicitly, either through null checks or using the new null-forgiving operator ! to assert that a nullable reference is not null.

- Oblivious types: 
Types without explicit annotations retain the previous behavior. Their nullability is determined based on the context or compiler settings.


## Sample
```
string? nullableString = null;
string nonNullableString = "Hello";

// nullableString can be assigned null
nullableString = "World";

// nonNullableString cannot be assigned null
// Uncommenting the line below would result in a compiler warning
// nonNullableString = null;

// Null check to avoid null reference exception
if (nullableString != null)
{
    int stringLength = nullableString.Length; // No warning, nullableString is checked for null
}

int nonNullableStringLength = nonNullableString.Length; // No warning, nonNullableString is non-nullable
```
