# Clean Architecture with ASP.NET Core 3.0-2019

By Jason Taylor
<https://www.youtube.com/watch?v=hV43fiHYBb4>
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
