
## Before C# 11

```cs
    var html = "<html>\n\t<body>\n\t\t<h1>Hello, World!</h1>\n\t</body>\n</html>";

    // Verbatim string contains ""
    var html = @"<html lang=""en"">";

```

## Raw string literals

Read the string as it is in code.

```cs
    var html = """<html lang="en">""";

    // put one " extra to escape the string contains """
    var html = """"  show "3 times:""" """";

    // String interpolation
    var htmlTag = $"""<html lang="{language}">"""

    // $$ escape the {} in the string
    var json = $$"""
    {

        "Logging":{
            "LogLevel" : {
                "Default": "{{logLevel         // Support new lines
                .toLower()}}"
            }
        }
    }
    """; // Indentation level is controlled by the space before the closing triple quotes
    Console.WriteLine(json);
```
