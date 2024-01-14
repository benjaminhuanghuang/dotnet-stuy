Change parameters to
```cs
public async Task<RestDTO<BoardGame[]>> Get(
    int pageIndex = 0,
    [Range(1, 100)] int pageSize = 10,
    string? sortColumn = "Name",
    [RegularExpression("ASC|DESC")] string? sortOrder = "ASC",
    string? filterQuery = null)
{
    
}
```


to 
```cs
public async Task<RestDTO<BoardGame[]>> Get([FromQuery] RequestDTO input)
```
