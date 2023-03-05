- Add appSettings.json
- Set property "Copy to Output Dierectory" to "Copy always"

```
IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appSettings.json")
                    .Build();

            Options = config.GetSection("Settings").Get<AppOptions>();
            Options ??= new AppOptions();
```

```
  builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("NET_ENVIRONMENT") ?? "Production"}.json", , optional: true)
        .AddEnvironmentVariables();
```