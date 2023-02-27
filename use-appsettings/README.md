## Add dependencies
```
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.Binder
Microsoft.Extensions.Configuration.Json
```


## Add a appSettings.json
Change its property 'Copy to Output Directory' to 'Copy always' 



## App.cs
```
public partial class App : Application
{
    public AppOptions Options { get; }
    public new static App Current => (App)Application.Current;

    public App()
    {
        IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json")
                .Build();

        Options = config.GetSection("Settings").Get<AppOptions>();
        Options ??= new AppOptions();
    }
}
```

## AppOptions
```
public class AppOptions
{
    public Dictionary<QueryType, QueryOptions> QueryConfiguration { get; set; }

    public AppOptions()
    {
        QueryConfiguration = new Dictionary<QueryType, QueryOptions>()
        {
            { QueryType.SQ, new QueryOptions() },
            { QueryType.DSQ, new QueryOptions() },
            { QueryType.DAX, new QueryOptions() },
        };
    }
}
```

## Read Options
```
    App.Current.Options.QueryConfiguration[queryType.Value].Format
```