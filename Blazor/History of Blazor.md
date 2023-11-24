Blazor lets you build interactive web user interface components using C# instead of JavaScript


Silverlight 2 was released in 2008, developer could use C# to build libraries and visual components that were executed in the web browser by the Silverlight plugin

By 2011 and Silverlight 5, MS abandon Silverlight, since it is banned from iPhones and iPads like Flash.

In 2017, the WebAssembly is supported by all major browsers.

## Blazor hosting models in .NET 7 and earlier
A Blazor Server project runs on the server side
A Blazor WebAssembly project runs on the client side, so the C# code only has access to resources in the browser.
A .NET MAUI Blazor App, aka Blazor Hybrid, project renders its web UI to a web view control.

## Unification of Blazor hosting models in .NET 8
- Server-Side Rendering (SSR)
- Streaming rendering
- Interactive server rendering
- Interactive WebAssembly rendering
- Interactive automatic rendering

This unified model means that, developer can write Blazor components once and then choose to run them on the web server side, or the web client side, or dynamically switch. 

## What is the difference between Blazor and Razor?
Razor is a template markup syntax that allows the mixing of HTML and C#.
