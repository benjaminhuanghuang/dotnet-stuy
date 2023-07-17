```
builder.Services.AddCors(options => options.AddPolicy(name: "SuperHeroOrigins",
policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

app.UseCors("SuperHeroOrigins");
```
