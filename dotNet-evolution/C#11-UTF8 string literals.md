UTF-8 is the character encoding used on the web

In .NET UTF-16 is the standard

Conversion is necessary when doing low-level web work

## Before C# 11

```cs
var utf8 = Encoding.UTF8.GetBytes("Hello, World!");
```

## C# 11

The span will not cause any memory allocation on the heap, more resource efficient and resource friendly

```cs
var utf8 = "header: "u8;   // returns a ReadOnlySpan<byte> instead of an array
```
