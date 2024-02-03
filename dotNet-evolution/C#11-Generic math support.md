


INumber is implemented by all numeric types.

```cs
T AddAll<T>(T[] values) where T : INumber<T>
{
    T result = T.Zero;
    T one = T.One;
    T max = T.Max(result, one);
    T abs = T.Abs(result);

    foreach (var value in values)
        result += value;

    return result;
}
```

Used extensively in .NET internally to simplify and reduce size of codebase
Example: Max and Sum extension methods in LINQ
