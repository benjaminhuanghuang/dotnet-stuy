# Add some Blazor pages into an existing MAUI app

Edit project file
change
```
<Project Sdk="Microsoft.NET.Sdk">
```
to
```
<Project Sdk="Microsoft.NET.Sdk.Razor">
```

Add MAUI Blazro web view into MauiProgram.cs
```
builder.Services.AddMauiBlazorWebView();

#if DEBUG
builder.Services.AddBlazorWebViewDeveloperTools();
#endif
```


Create folder Shared in the project root and create a MainLayout.razor file in it


Create a global imports _impports.razor all Blazor files to use
```
@using MauiNotes.Views
@using MauiNotes.Shared
@using System.Net.Http
@using Microsoft.AspNetCore.Components.Forms
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using Microsoft.JSInterop              // Speak to javascript, for IJSRuntime
```

Create a wwwroot fold to store CSS and html for the Blazor pages.


Add Blazor pages into Views folder

Add Main.razor into root folder
```
<Router AppAssembly="@typeof (Main).Assembly"›
<Found Context="routeData"›
<RouteView RouteData="@routeData" DefaultLayout="@typeof (Mainlayout)" />
</Found>
<NotFound>
<LayoutView Layout="@typeof (MainLayout)">
<p role="alert">Sorry, there's nothing at this address.</p>
</LayoutView>
</NotFound>
</Router>
```

Add BlazorWebView into BlazorContainerPage.xaml
```
<BlazorWebView Hostage="wwwroot/index.htmI"'>
    <BlazorWebView.RootComponents>
    <RootComponent Selector="#app" ComponentType=" {x: Type local:Main}" />
    </BlazorWebView.RootComponents>
</BlazorWebView>
```
