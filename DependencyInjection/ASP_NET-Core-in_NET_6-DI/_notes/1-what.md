

Dependency injection allows you to inject separate services into a class that it relies on.

Dependent objects of a class can be created elsewhere rather than in the class itself.
Correct


## lifetime

- singleton

A singleton service cannot depend directly on a scoped service as it does not know which scope it belongs to.

A singleton service will be initialized once for the application's lifetime. It will be disposed of when the application is shut down

- scoped
For example. a scoped service is used for a HTTP request in ASP.NET Core?
A scoped service is requested when the HTTP request is made. Once the request has finished, the scope is disposed of, and a response is returned.

- transient


