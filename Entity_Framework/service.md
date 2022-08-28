

## Inject service

```
    // Program.cs
    
    builder.Services.AddScoped<IMoviesService, MoviesService>();
```