
Blazor 是.NET最新的前端技术，也是用Razor作为模板，而用C#来编写页面逻辑，呈现交互的效果。与之前的Razor应用不同的是，Blazor是支持双向绑定的，也就是不需要页面刷新使服务端的重新渲染，而是实现了局部渲染，使Blazor能实现现代前端框架的效果。

Blazor有两种模式，一种是Blazor Server，一种是Blazor WebAssembly。Blazor Server是将所有的逻辑都放在服务端，而客户端只是一个渲染的工具，而Blazor WebAssembly则是将所有的逻辑都放在客户端，而服务端只是提供数据的接口。Blazor Server的优点是可以使用服务端的所有资源，而Blazor WebAssembly则是可以实现离线应用，不需要服务端的支持。

https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro

Create project
```
    dotnet new blazorserver -o FirstBlazorApp
```
