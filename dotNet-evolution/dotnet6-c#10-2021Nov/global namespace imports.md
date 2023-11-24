
## global namespace imports
The global using keyword combination means you only need to import a namespace in one .cs file and it will be available throughout all .cs files instead of having to import the namespace at the top of every file that needs it.

It recommend creating a separate file for those statements named something like GlobalUsings.cs with the contents being all your global using statements

```cs
global using System;
global using System.Linq;
global using System.Collections.Generic;

```

Any projects that target .NET 6 or later, and therefore use the C# 10 or later compiler, generate a 
<ProjectName>.GlobalUsings.g.cs file 
in the obj\Debug\net8.0 folder to implicitly globally import some common namespaces like System
