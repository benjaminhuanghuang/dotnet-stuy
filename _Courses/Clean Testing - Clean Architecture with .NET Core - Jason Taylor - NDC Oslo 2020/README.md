# Clean Testing - Clean Architecture with .NET Core - Jason Taylor - NDC Oslo 2020

By Jason Taylor
<https://www.youtube.com/watch?v=T6NRcX1vnz8>
<https://www.bilibili.com/video/BV15W4y1Q7Ph/>

## Subcutaneous Tests

- A test that operates just below the Ul
- Verify the basic inputs and outputs of the system
- Ideal if you keep logic out of the Ul
- Reduces the need for Ul tests

## Frameworks

NUnit, xUnit, MSTest: The most popular unit testing frameworks for .NET

FluentAssertions: A very popular assertion library for .NET

Moq: The most popular and friendly mocking framework for .NET

Respawn: Intelligent database cleaner for integration tests

## Setup

```bash
    dotnet new install Clean.Architecture.Solution.Template
    dotnet new ca-sln
```

Test
src\Application\TodoLists\Queries\GetTodos\GetTodos.cs
