https://aka.ms/new-console-template

## Requirements for top-level programs
There can be only one file like this in a project.

Any using statements must be at the top of the file.

If you declare any classes or other types, they must be at the bottom of the file.

Although you should name the method Main if you explicitly define it, the method is named <Main>$ when created by the compiler.





## Create console app do not use top-level program
```bash
dotnet new console --use-program-main
```
