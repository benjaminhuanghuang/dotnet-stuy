

# Navigating Between Pages in .NET MAUI [6 of 8] | .NET MAUI for Beginners

https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY

https://github.com/dotnet/maui-samples/tree/main/6.0/Beginners-Series?WT.mc_id=dotnet-29192-cxa&wt.mc_id=3reg_16711_webpage_reactor

## URI Shell-based navigation

Shell gives a structure to our application

Shell includes a built-in dependency service to do constructor injection and dependency injection

Shell also enables us to do a URI-based navigation

```
    public AppShell() {

        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
```


```
    await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Query={query}", new Directory<string, object> {});
```